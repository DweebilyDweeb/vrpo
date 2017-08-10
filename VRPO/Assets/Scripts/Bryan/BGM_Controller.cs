using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM_Controller : MonoBehaviour {

    public static BGM_Controller instance;
    public AudioSource audio;

    private float originalVolume;
    private AudioClip newClip;
    private bool fading;

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
        audio = GetComponent<AudioSource>();
        originalVolume = audio.volume;
	}
	
	// Update is called once per frame
	void Update () {
        if (fading)
        {
            if (audio.volume > 0.01)
                audio.volume -= 0.33f * Time.deltaTime;
            else
            {
                fading = false;
                audio.clip = newClip;
                audio.Play();
            }
        }
        else
        {
            if (audio.volume < originalVolume)
                audio.volume += 0.33f * Time.deltaTime;
            else if (audio.volume > originalVolume)
                audio.volume = originalVolume;
        }
	}

    public void PlayBGM(string name)
    {
        audio.clip = Resources.Load<AudioClip>("Sounds/BGM/" + name);
        audio.Play();
    }

    public void FadeToNewBGM(string name)
    {
        newClip = Resources.Load<AudioClip>("Sounds/BGM/" + name);
        fading = true;
    }
}
