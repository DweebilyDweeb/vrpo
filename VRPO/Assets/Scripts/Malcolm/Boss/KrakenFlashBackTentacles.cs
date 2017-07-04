using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KrakenFlashBackTentacles : MonoBehaviour {
    private KeyCode Attack;
    Animator anim;
	// Use this for initialization
	void Start ()
    {
        Attack = KeyCode.Keypad5;
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        RunAnimation();
	}

    void RunAnimation()
    {
        if (Input.GetKey(Attack))
        {
            anim.SetTrigger("Attack");
        }
    }
}
