﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParrotAudioTrigger : MonoBehaviour 
{
    public int dialogue;
    private bool triggered = false;
	// Use this for initialization
	void Start () 
    {

	}
	
	// Update is called once per frame
	void Update () 
    {
		
	}

    void OnTriggerEnter(Collider collision)
    {
        if (!triggered)
        {
            switch (collision.tag)
            {
                case "Boat":
                    triggered = true;
                    AudioSource parrotDialogue = collision.transform.Find("Parrot").GetComponent<AudioSource>();
                    parrotDialogue.PlayOneShot(GetParrotDialogue());
                    break;
            }
        }
    }

    AudioClip GetParrotDialogue()
    {
        return ParrotDialogueHolder.instance.dialogueList[dialogue - 1];
    }
}
