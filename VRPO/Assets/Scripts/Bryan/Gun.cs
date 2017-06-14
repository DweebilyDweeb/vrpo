using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour 
{
    private ViveController_Manager controller;
	// Use this for initialization
	void Start() 
    {
        controller = gameObject.GetComponentInParent<ViveController_Manager>();
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