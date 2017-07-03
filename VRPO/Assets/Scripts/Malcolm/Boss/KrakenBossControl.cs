using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KrakenBossControl : MonoBehaviour {

    private KeyCode Dive, Rise, Horizontal, Vertical;
    Animator anim;
	// Use this for initialization
	void Start ()
    {
        Dive = KeyCode.Keypad1;
        Rise = KeyCode.Keypad2;
        Horizontal = KeyCode.Keypad3;
        Vertical = KeyCode.Keypad4;
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        RunAnimation();
	}

    void RunAnimation()
    {
        if (Input.GetKey(Dive))
        {
            anim.SetTrigger("Dive");
        }

        if (Input.GetKey(Rise))
        {
            anim.SetTrigger("Rise");
        }

        if (Input.GetKey(Horizontal))
        {
            anim.SetTrigger("Atk_Horizontal");
        }

        if (Input.GetKey(Vertical))
        {
            anim.SetTrigger("Atk_Vertical");
        }
    }
}
