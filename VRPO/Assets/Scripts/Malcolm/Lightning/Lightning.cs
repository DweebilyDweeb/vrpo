using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightning : MonoBehaviour {

    float randomX;
    float randomZ;
    public GameObject LightningBolt;
    private GameObject Player;
    Quaternion randomRot;
	// Use this for initialization
	void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        StartCoroutine(Wait(UnityEngine.Random.Range(3,8)));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Wait(float seconds)
    {
        for (int x = 0; x < 1; x = 0)
        {
            yield return new WaitForSeconds(seconds); //this will wait 5 seconds
            SpawnLightning();
        }
    }

    private Vector3 RandomPosition()
    {
        randomX = UnityEngine.Random.Range(-200,200);
        randomZ = UnityEngine.Random.Range(-200, 200);
        return new Vector3(randomX, 0, randomZ);
    }

    private Quaternion RandomRotation()

    {
        //randomRot.eulerAngles = new Vector3(0, UnityEngine.Random.Range(-180, 180), 0);
        randomRot.eulerAngles = Vector3.zero;
        return randomRot;
    }

    private void SpawnLightning()
    {
        GameObject lightning = Instantiate(LightningBolt, RandomPosition(), RandomRotation());
        lightning.transform.LookAt(Player.transform);
    }

}
