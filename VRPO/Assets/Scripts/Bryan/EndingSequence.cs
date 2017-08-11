using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingSequence : MonoBehaviour 
{
    public static EndingSequence instance;
    private Animator anim;

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

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}

    public void BeginSequence()
    {
        StartCoroutine(TriggerCredits());
    }

    private IEnumerator TriggerCredits()
    {
        yield return new WaitForSeconds(1.5f);
        anim.SetTrigger("Credits");
    }

    private IEnumerator TriggerReplay()
    {
        yield return new WaitForSeconds(3);
        anim.SetTrigger("Replay");
    }
}
