using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeControl : MonoBehaviour
{
    public bool slowMo;

    public static TimeControl instance;

    public TimeControl() { }

    void Awake()

    {
        // if the singleton hasn't been initialized yet
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;//Avoid doing anything else
        }

        instance = this;
        this.gameObject.tag = "TimeControl";
        DontDestroyOnLoad(this.gameObject);
    }

    // Use this for initialization
    void Start ()
    {
        slowMo = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
        TimeSlow();
        AudioSlow();
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
}
