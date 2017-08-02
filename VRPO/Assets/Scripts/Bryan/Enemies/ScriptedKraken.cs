using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptedKraken : MonoBehaviour 
{
    public List<GameObject> targetList = new List<GameObject>();
    public List<GameObject> spawnPoints = new List<GameObject>();
    private bool spawnPointInit = false;
    private bool targetsSpawned = false;

    private float atkTimer;
    private float atkTimeDefault = 2.0f;

    private enum Kraken_FSM { Spawn = 1, Idle, Dive, Rise, Attack_R_Tentacle_Horizontal, Attack_R_Tentacle_Vertical }
    private Kraken_FSM currentState = Kraken_FSM.Spawn;
    private Animator anim;
    private AudioSource audio;

    private int atkCounter = 0;
    public bool hasRisen;
    private bool knockedBack = false;
    public int hp = 4;
	// Use this for initialization
	void Start ()
    {
        atkTimer = atkTimeDefault;
		anim = GetComponent<Animator>();
        audio = GetComponent<AudioSource>();
        spawnPoints.Add(transform.Find("Kraken_Armature").Find("Tentacle_01").gameObject);
	}
	
	// Update is called once per frame
	void Update () 
    {
		if(!spawnPointInit)
        {
            if (spawnPoints[spawnPoints.Count - 1].transform.childCount != 0)
                spawnPoints.Add(spawnPoints[spawnPoints.Count - 1].transform.GetChild(0).gameObject);
            else
                spawnPointInit = true;
        }

        if (hp <= 0)
            SetFSM(Kraken_FSM.Dive);

        switch (currentState)
        {
            case Kraken_FSM.Idle:
                if (atkTimer > 0)
                    atkTimer -= Time.deltaTime;
                else
                {
                    switch (atkCounter)
                    {
                        case 0:
                            SetFSM(Kraken_FSM.Attack_R_Tentacle_Horizontal);
                            atkTimer = atkTimeDefault;
                            break;
                        case 1:
                            SetFSM(Kraken_FSM.Attack_R_Tentacle_Vertical);
                            atkTimer = atkTimeDefault;
                            break;
                        default: 
                            bool verticalAtk = HelperFunctions.RandomBool();

                            if (!verticalAtk)
                                SetFSM(Kraken_FSM.Attack_R_Tentacle_Horizontal);
                            else
                                SetFSM(Kraken_FSM.Attack_R_Tentacle_Vertical);

                            atkTimer = atkTimeDefault;
                            break;
                    }
                }
                break;
            case Kraken_FSM.Attack_R_Tentacle_Horizontal:
                TentacleAttack();
                break;
            case Kraken_FSM.Attack_R_Tentacle_Vertical:
                TentacleAttack();
                break;
        }
	}

    void SetFSM(Kraken_FSM state)
    {
        try
        {
            Debug.Log("SetFSM called, state = " + state);
            currentState = state;

            switch (currentState)
            {
                case Kraken_FSM.Dive:
                    anim.SetTrigger("Dive");
                    break;
                case Kraken_FSM.Rise:
                    anim.SetTrigger("Rise");
                    break;
                case Kraken_FSM.Attack_R_Tentacle_Horizontal:
                    atkCounter++;
                    anim.SetTrigger("Atk_Horizontal");
                    Debug.Log("atkCounter: " + atkCounter);
                    break;
                case Kraken_FSM.Attack_R_Tentacle_Vertical:
                    atkCounter++;
                    anim.SetTrigger("Atk_Vertical");
                    Debug.Log("atkCounter: " + atkCounter);
                    break;
            }
        }
        catch (Exception e) { Debug.LogError("Kraken SetFSM function failed, reason: " + e); }
    }

    void SpawnTargetColliders()
    {
        switch (currentState)
        {
            case Kraken_FSM.Attack_R_Tentacle_Horizontal:
                {
                    List<int> pointsToSpawn = new List<int>() { 8, 14, 20 };
                    foreach (int point in pointsToSpawn)
                    {
                        GameObject targetCollider = Instantiate(Resources.Load<GameObject>("Prefabs/Enemies/KrakenCollider"), spawnPoints[point - 1].transform);
                        targetCollider.transform.localPosition = Vector3.zero;
                        targetList.Add(targetCollider);
                    }

                    targetsSpawned = true;
                    knockedBack = false;
                    break;
                }
            case Kraken_FSM.Attack_R_Tentacle_Vertical:
                {
                    List<int> pointsToSpawn = new List<int>() { 8, 14, 20 };
                    foreach (int point in pointsToSpawn)
                    {
                        GameObject targetCollider = Instantiate(Resources.Load<GameObject>("Prefabs/Enemies/KrakenCollider"), spawnPoints[point - 1].transform);
                        targetCollider.transform.localPosition = Vector3.zero;
                        targetList.Add(targetCollider);
                    }

                    targetsSpawned = true;
                    knockedBack = false;
                    break;
                }
            default:
                Debug.LogError("currentState is not an attack state");
                break;
        }
        //StartCoroutine(Test());
    }

    void DespawnTargetColliders()
    {
        if (targetList.Count != 0)
        {
            foreach (GameObject targetCollider in targetList)
            {
                Destroy(targetCollider);
            }
            targetList.Clear();
            ToggleSlowMo(1);
            targetsSpawned = false;
        }
    }

    void ToggleSlowMo(int On)
    {
        if(On == 0)
            TimeControl.instance.slowMo = true;
        else
            TimeControl.instance.slowMo = false;
    }

    void TentacleAttack()
    {
        if (!knockedBack)
        {
            if (targetsSpawned)
            {
                int hitCount = 0;
                #region check if targets are hit
                for (int i = 0; i <= targetList.Count - 1; i++)
                {
                    if (targetList[i].GetComponent<Billboard>().isHit)
                        hitCount++;
                }
                #endregion

                if (hitCount == (targetList.Count))
                {
                    hp -= 1;
                    knockedBack = true;
                    anim.SetTrigger("Knockback");
                }
            }
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (!hasRisen)
        {
            if (collision.tag == "Boat")
            {
                SetFSM(Kraken_FSM.Rise);
                hasRisen = true;
            }
        }
    }

    void PlaySound(string file)
    {
        audio.PlayOneShot(Resources.Load<AudioClip>("Sounds/Kraken/" + file));
    }
}
