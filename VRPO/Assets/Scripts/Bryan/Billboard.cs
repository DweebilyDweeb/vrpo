using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Billboard : MonoBehaviour 
{
    GameObject player;
    public bool isHit;
	// Use this for initialization
	void Start () 
    {
        player = GameObject.FindGameObjectWithTag("Player");

        isHit = false;
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(player.transform);
	}

    public void TriggerHit()
    {
        isHit = true;
        GetComponent<Collider>().enabled = false;
        GetComponentInChildren<SpriteRenderer>().enabled = false;
    }
}
