using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViveControllerManager : MonoBehaviour 
{
    private ViveController controller;
    public GameObject flintlock, cutlass;
    private GameObject raycast;

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

        raycast = flintlock.transform.Find("Raycast").gameObject;
        laserActive = false;
        Mode = PlayerPrefs.GetString(gameObject.name + "_Mode", "Gun");
        audio = GetComponent<AudioSource>();

        LoadMode(Mode);
    }

    // Update is called once per frame
    void Update()
    {
        controller.Update();

        #region Laser Pointer
        if (!laserActive)
            raycast.SetActive(false);
        else if (laserActive)
            raycast.SetActive(true);
        #endregion

        if (controller.device.GetPressDown(controller.menuButton))
        {
            if (Mode == "Gun")
                LoadMode("Sword");
            else if (Mode == "Sword")
                LoadMode("Gun");
        }

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
                                if (ParrotScriptedDialogue.instance.gameState == ParrotScriptedDialogue.State.howToShoot)
                                    ParrotScriptedDialogue.instance.SwitchState(ParrotScriptedDialogue.State.unsheatheSword);
                            }
                        }
                        catch (Exception e) { Debug.LogError(e); }
                        break;
                        #endregion
                    case 2:
                        #region Fire at will
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

    private void LoadMode(string mode)
    {
        switch(mode)
        {
            case "Gun": // In gun mode, switch to sword
                Mode = "Gun";
                anim = flintlock.GetComponent<Animator>();
                cutlass.SetActive(false);
                flintlock.SetActive(true);
                audio.PlayOneShot(Resources.Load<AudioClip>("Sounds/Guns/GunDraw"));
                break;
            case "Sword":
                Mode = "Sword";
                anim = cutlass.GetComponent<Animator>();
                flintlock.SetActive(false);
                cutlass.SetActive(true);
                laserActive = false;
                audio.PlayOneShot(Resources.Load<AudioClip>("Sounds/Sword/SwordDraw"));
                if (ParrotScriptedDialogue.instance.gameState == ParrotScriptedDialogue.State.unsheatheSword)
                    ParrotScriptedDialogue.instance.SwitchState(ParrotScriptedDialogue.State.cutVines);
                break;
        }
    }

    private void RaycastInteraction()
    {
        Ray ray = new Ray(raycast.transform.position, raycast.transform.forward);
        RaycastHit _hit;
        if (Physics.Raycast(ray, out _hit))
        {
            GameObject collision = _hit.collider.gameObject;
            switch (collision.tag)
            {
                case "Cannonball":
                    collision.gameObject.GetComponent<Projectile>().DestroyProjectile();
                    break;
                case "Bird":
                    GameObject.FindGameObjectWithTag("GameController").GetComponent<ScoreSystem>().AddScore(10);
                    GameObject particles = Instantiate(Resources.Load<GameObject>("Prefabs/Particle Effects/Seagull_Death_Particles_Feathers"), collision.transform.position, collision.transform.rotation);
                    Destroy(collision.gameObject);
                    Instantiate(Resources.Load<GameObject>("Prefabs/Animals/Seagull"));
                    break;
                case "Piranha":
                    GameObject.FindGameObjectWithTag("GameController").GetComponent<ScoreSystem>().AddScore(10);
                    Destroy(collision.gameObject);
                    break;
                case "Goblin":
                    if (collision.GetComponent<Goblin>().getCurrentState() != Goblin.Goblin_FSM.Death)
                    {
                        GameObject.FindGameObjectWithTag("GameController").GetComponent<ScoreSystem>().AddScore(50);
                        collision.gameObject.GetComponent<Goblin>().TriggerDeath();
                    }
                    break;
                case "Kraken":
                    GameObject.FindGameObjectWithTag("GameController").GetComponent<ScoreSystem>().AddScore(50);
                    collision.GetComponent<Billboard>().TriggerHit();
                    break;
#if UNITY_EDITOR
                case "Rope":
                    collision.gameObject.GetComponent<Rope>().TriggerCut();
                    break;
#endif
            }
        }
    }

    public void FireGun()
    {
        audio.PlayOneShot(Resources.Load<AudioClip>("Sounds/Guns/GunFire"));

        RaycastInteraction();
        if (!TimeControl.instance.slowMo)
        {
            GameObject flintlockSmoke = Instantiate(Resources.Load<GameObject>("Prefabs/Particle Effects/FlintlockSmoke"));
            flintlockSmoke.GetComponent<ParticleEffects>().Init(flintlock.transform.Find("SmokeLocation").transform, flintlock.transform.Find("SmokeLocation").transform);

            GameObject muzzleFlash = Instantiate(Resources.Load<GameObject>("Prefabs/Particle Effects/MuzzleFlash"));
            muzzleFlash.GetComponent<ParticleEffects>().Init(flintlock.transform.Find("MuzzleFlashLocation").transform, flintlock.transform.Find("MuzzleFlashLocation").transform);
        }
    }
}
