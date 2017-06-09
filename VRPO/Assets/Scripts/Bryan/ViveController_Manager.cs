using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViveController_Manager : MonoBehaviour 
{
    private ViveController controller;
    private bool laserActive = true;

    private string Mode;

    private float gunChargeTimer = 2.0f;
    private bool gunCharged = false;
    

    // Use this for initialization
    void Start()
    {
        controller = new ViveController();
        controller.trackedObject = gameObject.GetComponent<SteamVR_TrackedObject>();

        Mode = PlayerPrefs.GetString(gameObject.name + "_Mode", "Gun");
    }

    // Update is called once per frame
    void Update()
    {
        controller.Update();
        
        #region Laser Pointer
        if (!laserActive)
            gameObject.GetComponent<SteamVR_LaserPointer>().holder.SetActive(false);
        else
            gameObject.GetComponent<SteamVR_LaserPointer>().holder.SetActive(true);
        #endregion
        
        switch(Mode)
        {
            case "Gun":
                #region Gun
                switch (PlayerPrefs.GetInt("FiringMode", 1))
                {
                    case 0:
                        #region Charge and fire
                        try
                        {
                            if (controller.device.GetPress(controller.touchPad))
                            {
                                if (!laserActive)
                                    laserActive = true;

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
                            if (controller.device.GetPressDown(controller.triggerButton) && gunCharged)
                            {
                                RaycastInteraction();
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
                                laserActive = true;
                            else
                                laserActive = false;

                            if (controller.device.GetPressDown(controller.triggerButton) && laserActive)
                            {
                                RaycastInteraction();
                                gunCharged = false;
                            }
                        }
                        catch (Exception e) { Debug.LogError(e); }
                        break;
                        #endregion
                    case 2:
                        #region Fire at will
                        if (!laserActive)
                            laserActive = true;
                        try
                        {
                            if (controller.device.GetPressDown(controller.triggerButton))
                                RaycastInteraction();
                        }
                        catch (Exception e) { Debug.LogError(e); }
                        break;
                        #endregion
                }
                #endregion
                break;
        }
    }

    private void RaycastInteraction()
    {
        Ray raycast = new Ray(transform.position, transform.forward);
        RaycastHit _hit;
        if (Physics.Raycast(raycast, out _hit))
        {
            GameObject collide = _hit.collider.gameObject;
            switch (collide.tag)
            {
                case "Cannonball":
                    Destroy(collide);
                    break;
            }
        }
    }
}
