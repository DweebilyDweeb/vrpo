using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    public void SetHit()
    {
        isHit = true;
        gameObject.SetActive(false);
    }
}
