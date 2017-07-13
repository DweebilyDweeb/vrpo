﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rope : MonoBehaviour 
{
    public bool isCut;
    private Animator anim;
	// Use this for initialization
	void Start () 
    {
        isCut = true;
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TriggerCut()
    {
        StartCoroutine(Cut());
    }

    private IEnumerator Cut()
    {
        anim.SetTrigger("Cut");
        yield return new WaitForSeconds(0.5f);
        isCut = true;
    }
}
