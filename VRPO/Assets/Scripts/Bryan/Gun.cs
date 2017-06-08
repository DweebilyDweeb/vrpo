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
        controller = new ViveController();
        controller.trackedObject = gameObject.GetComponent<SteamVR_TrackedObject>();
	}
	
	// Update is called once per frame
	void Update () 
    {
        controller.Update();
        #region Laser Pointer
        if(!gunCharged)
            gameObject.GetComponent<SteamVR_LaserPointer>().holder.SetActive(false);
        else
            gameObject.GetComponent<SteamVR_LaserPointer>().holder.SetActive(true);
        #endregion

        switch(PlayerPrefs.GetInt("FiringMode", 1))
        {
            case 0:
                #region Charge and fire
                try
                {
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
                    if (controller.device.GetPressUp(controller.triggerButton) && gunCharged)
                    {
                        Fire();
                        gunChargeTimer = 2.0f;
                        gunCharged = false;
                    }
                }
                catch (Exception e) { Debug.LogError(e); }
                break;
                #endregion
            case 1:
                #region Hold Down Track Pad and Fire
                try
                {
                    if (controller.device.GetPress(controller.touchPad))
                        gunCharged = true;
                    else
                        gunCharged = false;

                    if (controller.device.GetPressDown(controller.triggerButton) && gunCharged)
                    {
                        Fire();
                        gunCharged = false;
                    }
                }
                catch (Exception e) { Debug.LogError(e); }
                break;
                #endregion
            case 2:
                #region Fire at will
                if (!gunCharged)
                    gunCharged = true;
                try
                {
                    if (controller.device.GetPressDown(controller.triggerButton))
                        Fire();
                }
                catch (Exception e) { Debug.LogError(e); }
                break;
                #endregion
        }
    }

    private void Fire()
    {
        Ray raycast = new Ray(transform.position, transform.forward);
        RaycastHit _hit;
        if (Physics.Raycast(raycast, out _hit))
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