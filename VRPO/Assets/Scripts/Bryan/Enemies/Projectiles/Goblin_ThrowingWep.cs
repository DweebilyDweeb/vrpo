﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin_ThrowingWep : Projectile
{
    private Animator anim;
    GameObject player;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player");
        transform.LookAt(player.transform);
	}

    public void Init(Vector3 vel)
    {
        //GetComponent<Rigidbody>().AddForce(vel);
        Rigidbody projectile = GetComponent<Rigidbody>();
        if (projectile.velocity.magnitude < 5.0f)
            projectile.velocity = vel;
    }

    void Update()
    {
        //Debug.Log("axe velocity: " + GetComponent<Rigidbody>().velocity);
    }
	
	private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Player":
                GameObject.FindGameObjectWithTag("GameController").GetComponent<ScoreSystem>().AddScore(-10);
                Destroy(gameObject);
                break;
            case "Boat":
                GameObject.FindGameObjectWithTag("GameController").GetComponent<ScoreSystem>().AddScore(-10);
                Destroy(gameObject);
                break;
            case "Terrain":
                SetDaggerIdle();
                Destroy(gameObject, 5.0f);
                break;
            case "Water":
                // Spawn particle effects
                Destroy(gameObject, 5.0f);
                break;
        }
    }

    private void SetDaggerIdle()
    {
        anim.SetTrigger("Idle");
        GetComponent<Rigidbody>().freezeRotation = false;
    }
}
