using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParrotScriptedDialogue : MonoBehaviour
{
    public static ParrotScriptedDialogue instance;
    public static float gameTimer = 0.0f;
    public bool speak;
    public enum State { wakingUp = 1, howToShoot, unsheatheSword, cutVines, pirateOnShip, end };
    public State gameState;

    public bool pirateBoarder = false;
    private bool firstSword = true;
    AudioSource parrotDialogue;

    void Awake()
    {
        // if the singleton hasn't been initialized yet
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;//Avoid doing anything else
        }

        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    void Start()
    {
        speak = true;
        gameState = State.end;
        //parrotDialogue = GameObject.FindGameObjectWithTag("Boat").transform.Find("Parrot").GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () 
    {
        gameTimer += Time.deltaTime;

        #region state machine
        switch (gameState)
        {
            case State.wakingUp:
                parrotDialogue = GameObject.FindGameObjectWithTag("Boat").transform.Find("Parrot").GetComponent<AudioSource>();
                ParrotTalk(1);
                if (gameTimer > 5.0f)
                    SwitchState(State.howToShoot);
                break;
            case State.howToShoot:
                AutoRepeatDialogue();
                if(firstSword)
                {
                    firstSword = false;
                    StartCoroutine(DelayedParrotTalk(2, 1.5f));
                }
                else
                    ParrotTalk(2);
                break;
            case State.unsheatheSword:
                AutoRepeatDialogue();
                ParrotTalk(3);
                break;
            case State.cutVines:
                AutoRepeatDialogue();
                ParrotTalk(4);
                break;
            case State.pirateOnShip:
                pirateBoarder = true;
                ParrotTalk(9);
                gameState = State.end;
                break;
            case State.end:
                break;
        }
        #endregion
    }

    void ParrotTalk(int dialogue)
    {
        if (speak)
        {
            speak = false;
            parrotDialogue.PlayOneShot(ParrotDialogueHolder.instance.dialogueList[dialogue - 1]);
        }
    }

    void AutoRepeatDialogue()
    {
        if (gameTimer > 15.0f)
        {
            gameTimer = 0;
            speak = true;
        }
    }

    public void SwitchState(State state)
    {
        gameTimer = 0;
        speak = true;
        gameState = state;
    }

    IEnumerator DelayedParrotTalk(int dialogue, float timer)
    {
        yield return new WaitForSeconds(timer);
        ParrotTalk(dialogue);
    }
}
