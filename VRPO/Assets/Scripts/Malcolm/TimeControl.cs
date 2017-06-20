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
	}
    public void TimeSlow()
    {
        if (slowMo == true)
        {
            Time.timeScale = 0.3f;
            if (Time.timeScale > 0.1f)
            {
                Time.timeScale -= Time.deltaTime;
            }
        }
        if (slowMo == false)
        {
            if (Time.timeScale < 1.0f)
            {
                Time.timeScale += Time.deltaTime * 5.0f;
            }
            if (Time.timeScale > 1.0f)
            {
                Time.timeScale = 1.0f;
            }
        }

    }
}
