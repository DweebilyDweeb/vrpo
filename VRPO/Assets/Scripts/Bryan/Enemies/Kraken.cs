using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kraken : MonoBehaviour 
{
    public List<GameObject> targetList = new List<GameObject>();
    public List<GameObject> spawnPoints = new List<GameObject>();
    private bool spawnPointInit = false;
    private float atkTimeDefault = 2.0f;
    private float atkTimer;

    private enum Kraken_FSM { Spawn = 1, Idle, Dive, Rise, Attack_R_Tentacle_Horizontal, Attack_R_Tentacle_Vertical }
    private Kraken_FSM currentState = Kraken_FSM.Spawn;
    private Animator anim;
	// Use this for initialization
	void Start () 
    {
        atkTimer = atkTimeDefault;
		anim = GetComponent<Animator>();

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

        switch(currentState)
        {
            case Kraken_FSM.Idle:
                if (atkTimer > 0)
                    atkTimer -= Time.deltaTime;
                else
                {
                    bool verticalAtk = HelperFunctions.RandomBool();

                    if (!verticalAtk)
                        SetFSM(Kraken_FSM.Attack_R_Tentacle_Horizontal);
                    else
                        SetFSM(Kraken_FSM.Attack_R_Tentacle_Vertical);

                    atkTimer = atkTimeDefault;
                }

                if (targetList.Count != 0)
                {
                    foreach (GameObject targetCollider in targetList)
                    {
                        Destroy(targetCollider);
                    }
                    targetList.Clear();
                }
                break;
            case Kraken_FSM.Attack_R_Tentacle_Horizontal:
                if (targetList.Count == 0)
                    ToggleSlowMo(1);
                // Toggle knockback
                break;
            case Kraken_FSM.Attack_R_Tentacle_Vertical:
                if (targetList.Count == 0)
                    ToggleSlowMo(1);
                // Toggle knockback
                break;
        }
	}

    void SetFSM(Kraken_FSM state)
    {
        Debug.Log("SetFSM called, state = " + state);
        currentState = state;

        switch(currentState)
        {
            case Kraken_FSM.Dive:
                anim.SetTrigger("Dive");
                break;
            case Kraken_FSM.Rise:
                anim.SetTrigger("Rise");
                break;
            case Kraken_FSM.Attack_R_Tentacle_Horizontal:
                anim.SetTrigger("Atk_Horizontal");
                break;
            case Kraken_FSM.Attack_R_Tentacle_Vertical:
                anim.SetTrigger("Atk_Vertical");
                break;
        }
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
                    break;
                }
            default:
                Debug.LogError("currentState is not an attack state");
                break;
        }
    }

    void ToggleSlowMo(int On)
    {
        if(On == 0)
            GameObject.FindGameObjectWithTag("TimeControl").GetComponent<TimeControl>().slowMo = true;
        else
            GameObject.FindGameObjectWithTag("TimeControl").GetComponent<TimeControl>().slowMo = false;
    }
}
