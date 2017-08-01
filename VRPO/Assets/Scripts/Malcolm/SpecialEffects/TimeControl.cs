using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeControl : MonoBehaviour
{
    public bool slowMo;

    public bool FastTime;

    public bool ReverseTime;

    public static TimeControl instance;

    public TimeControl() { }

    private KeyCode SpeedTime;

    private KeyCode NormalTime;

    private KeyCode SkipFlashback;

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
    void Start ()
    {
        slowMo = false;
        SpeedTime = KeyCode.F1;
        NormalTime = KeyCode.F3;
        SkipFlashback = KeyCode.F12;
    }
	
	// Update is called once per frame
	void Update ()
    {
        TimeSlow();
        AudioSlow();
        TimeSpeed();

        if(Input.GetKeyDown(SkipFlashback))
        {
            SceneManager.LoadScene("demoScene10");
            ParrotScriptedDialogue.instance.SwitchState(ParrotScriptedDialogue.State.wakingUp);
        }
	}
    public void TimeSlow()
    {
        if (slowMo == true)
        {
            var aSources = FindObjectsOfType<AudioSource>();
            Time.timeScale = 0.3f;
            if (Time.timeScale > 0.1f)
            {
                Time.timeScale -= Time.deltaTime;
                foreach (AudioSource aSource in aSources)
                    aSource.pitch = Time.timeScale;
            }
        }
        if (slowMo == false)
        {
            var aSources = FindObjectsOfType<AudioSource>();
            if (Time.timeScale < 1.0f)
            {
                Time.timeScale += Time.deltaTime * 5.0f;
                foreach (AudioSource aSource in aSources)
                    aSource.pitch = Time.timeScale;
            }
            if (Time.timeScale > 1.0f)
            {
                Time.timeScale = 1.0f;
                foreach (AudioSource aSource in aSources)
                    aSource.pitch = Time.timeScale;
            }
        }

    }

    public void AudioSlow()
    {
        var aSources = FindObjectsOfType<AudioSource>();
        foreach (AudioSource aSource in aSources)
            aSource.pitch = Time.timeScale;
    }

    public void TimeSpeed()
    {
        if (Input.GetKeyDown(SpeedTime) && FastTime == false)
        {
            FastTime = true;
        }

        if (Input.GetKeyDown(NormalTime))
        {
            FastTime = false;
        }

        if (FastTime == true)
        {
            Time.timeScale = 10.0f;
        }

    }
}
