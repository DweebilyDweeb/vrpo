using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParrotDialogueHolder : MonoBehaviour
{
    public static ParrotDialogueHolder instance;
    public List<AudioClip> dialogueList = new List<AudioClip>();

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
    void Start()
    {
        foreach (AudioClip audio in Resources.LoadAll("Sounds/Parrot"))
        {
            dialogueList.Add(audio);
        }
    }
}
