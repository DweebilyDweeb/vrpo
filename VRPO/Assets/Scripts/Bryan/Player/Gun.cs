using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour 
{
    private ViveControllerManager controller;
    private Animator anim;
	// Use this for initialization
	void Start() 
    {
        controller = gameObject.GetComponentInParent<ViveControllerManager>();
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () 
    {
        CheckForSlowMo();
    }

    public void Fire()
    {
        controller.FireGun();
    }

    private void CheckForSlowMo()
    {
        if (TimeControl.instance.slowMo)
        {
            anim.speed = 7.5f;
        }
        if (!TimeControl.instance.slowMo)
        {
            anim.speed = 1.0f;
        }
    }
}