using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour 
{
    private ViveController controller;
    private float gunChargeTimer = 2.0f;
    private bool gunCharged = false;
	// Use this for initialization
	void Start () 
    {
        //controller = gameObject.GetComponent<ViveController>();
        controller = new ViveController();
        controller.trackedObject = GetComponent<SteamVR_TrackedObject>();
	}
	
	// Update is called once per frame
	void Update () 
    {
        controller.Update();
        if (controller.device.GetPressDown(controller.triggerButton))
        {
            if (gunChargeTimer > 0)
                gunChargeTimer -= Time.deltaTime;
            else
                gunCharged = true;
        }
        else
        {
            if (gunChargeTimer < 2 && !gunCharged)
                gunChargeTimer += Time.deltaTime;
        }
        if(controller.device.GetPressUp(controller.triggerButton) && gunCharged)
        {
            Fire();
            gunChargeTimer = 2.0f;
            gunCharged = false;
        }
        //try
        //{
        //    if (controller.device.GetPressDown(controller.triggerButton))
        //    {
        //        Debug.Log("Controller Pressed");
        //        Fire();
        //    }
        //}
        //catch(Exception e) { Debug.LogError(e); }
	}

    private void Fire()
    {
        //Destroy(GameObject.Find("Ship"));
        Debug.Log("Fired");
        int layerMask = 1 << 8;
        RaycastHit _hit;
        if (Physics.Raycast(transform.position, transform.forward * 10, out _hit, 10.0f, layerMask))
        {
            GameObject collide = _hit.collider.gameObject;
            switch(collide.tag)
            {
                case "Cannonball":
                    Destroy(collide);
                    break;
            }
        }
    }
}