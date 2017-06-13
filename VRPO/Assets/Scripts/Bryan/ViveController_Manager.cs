using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViveController_Manager : MonoBehaviour 
{
    private ViveController controller;
    public GameObject flintlock;

    private bool laserActive = true;

    private string Mode;

    private float gunChargeTimer = 2.0f;
    private bool gunCharged = false;

    private AudioSource audio;
    private Animator anim;

    // Use this for initialization
    void Start()
    {
        controller = new ViveController();
        controller.trackedObject = gameObject.GetComponent<SteamVR_TrackedObject>();

        laserActive = false;
        Mode = PlayerPrefs.GetString(gameObject.name + "_Mode", "Gun");
        audio = GetComponent<AudioSource>();
        anim = flintlock.GetComponent<Animator>();
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

        switch (Mode)
        {
            case "Gun":
                #region Gun
                switch (1)//PlayerPrefs.GetInt("FiringMode", 1))
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
                                FireGun();
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
                            if (controller.device.GetPressDown(controller.touchPad))
                            {
                                if(!laserActive)
                                    laserActive = true;
                            }
                            else if (controller.device.GetPressUp(controller.touchPad))
                            {
                                if (laserActive)
                                    laserActive = false;
                            }

                            if (controller.device.GetPressDown(controller.triggerButton) && laserActive)
                            {
                                FireGun();
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
                            {
                                FireGun();
                            }
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

    private void FireGun()
    {
        audio.Play();
        anim.SetTrigger("Fire");
        RaycastInteraction();
        GameObject flintlockSmoke = Instantiate(Resources.Load<GameObject>("Prefabs/Cannon/CannonSmoke2"), flintlock.transform.Find("SmokeLocation").transform.position, flintlock.transform.Find("SmokeLocation").transform.rotation, flintlock.transform.Find("SmokeLocation"));
        flintlockSmoke.transform.localEulerAngles += new Vector3(90, 0, 0);
    }
}
