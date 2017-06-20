using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour 
{
    private ViveControllerManager controller;
	// Use this for initialization
	void Start() 
    {
        controller = gameObject.GetComponentInParent<ViveControllerManager>();
	}
	
	// Update is called once per frame
	void Update () 
    {
        
    }

    public void Fire()
    {
        controller.FireGun();
    }
}