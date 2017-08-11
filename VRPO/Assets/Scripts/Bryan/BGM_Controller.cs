using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM_Controller : MonoBehaviour {

    public static BGM_Controller instance;
    public AudioSource audio;

    private float originalVolume;
    public List<AudioClip> bgmList = new List<AudioClip>();
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

        foreach (AudioClip bgm in Resources.LoadAll("Sounds/BGM"))
        {
            bgmList.Add(bgm);
        }
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

    public void PlayBGM(int bgm)
    {
        audio.clip = bgmList[bgm - 1];
        audio.Play();
    }

    public void FadeToNewBGM(int bgm)
    {
        newClip = bgmList[bgm - 1];
        fading = true;
    }
}
