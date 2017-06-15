using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViveController_Manager : MonoBehaviour 
{
    private ViveController controller;
    public GameObject flintlock, cutlass;

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

        InitMode();
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

        if(controller.device.GetPressDown(controller.menuButton))
            InitMode();

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
                                anim.SetTrigger("Fire");
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
                                anim.SetTrigger("Fire");
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
                                anim.SetTrigger("Fire");
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

    private void InitMode()
    {
        switch (Mode)
        {
            case "Gun":
                Mode = "Gun";
                anim = flintlock.GetComponent<Animator>();
                cutlass.SetActive(false);
                flintlock.SetActive(true);
                break;
            case "Sword":
                Mode = "Sword";
                anim = cutlass.GetComponent<Animator>();
                flintlock.SetActive(false);
                cutlass.SetActive(true);
                laserActive = false;
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
                    collide.gameObject.GetComponent<Cannonball>().KillCannonball();
                    break;
                case "Bird":
                    GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().AddHP(3);
                    Destroy(collide.gameObject);
                    Instantiate(Resources.Load<GameObject>("Prefabs/Animals/Seagull"));
                    break;
            }
        }
    }

    public void FireGun()
    {
        audio.Play();
        //anim.SetTrigger("Fire");
        RaycastInteraction();
        GameObject flintlockSmoke = Instantiate(Resources.Load<GameObject>("Prefabs/Particle Effects/FlintlockSmoke"), flintlock.transform.Find("SmokeLocation").transform.position, flintlock.transform.Find("SmokeLocation").transform.rotation, flintlock.transform.Find("SmokeLocation"));
        
        GameObject muzzleFlash = Instantiate(Resources.Load<GameObject>("Prefabs/Particle Effects/MuzzleFlash"), flintlock.transform.Find("MuzzleFlashLocation").transform.position, new Quaternion(0,0,0,0), flintlock.transform.Find("MuzzleFlashLocation"));
    }
}
