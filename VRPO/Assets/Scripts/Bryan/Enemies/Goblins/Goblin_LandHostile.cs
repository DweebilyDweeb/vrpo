﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin_LandHostile : Goblin
{
    public GameObject leftHand, rightHand;
    public float detectionRange;
    private float distFromPlayer;
    private bool inRange, hasDetectedPlayer;
    private GameObject player;
    private Vector3 direction;

	// Use this for initialization
	void Start () 
    {
        hasDetectedPlayer = false;
        anim = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update ()
    {        
		switch(currentState)
        {
            case Goblin_FSM.Idle:
                #region check if player is in range
                distFromPlayer = new Vector3(player.transform.position.x - transform.position.x, 0, player.transform.position.z - transform.position.z).magnitude;

                if (distFromPlayer < detectionRange)
                {
                    inRange = true;
                    if (!hasDetectedPlayer)
                        hasDetectedPlayer = true;
                }
                else
                    inRange = false;
                #endregion

                if (inRange)
                {
                    transform.LookAt(new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z));
                    direction = player.transform.position - transform.position;
                    currentState = Goblin_FSM.Unsheathe;
                }
                break;
            case Goblin_FSM.Unsheathe:
                anim.SetTrigger("Unsheathe");
                currentState = Goblin_FSM.Idle;
                break;
            case Goblin_FSM.Death:
                anim.SetTrigger("Death");
                bool anim1 = HelperFunctions.RandomBool();
                if(!hasDetectedPlayer) // Play unalarmed death animations
                {
                    if (anim1)
                        anim.SetInteger("Death_Type", 1);
                    else
                        anim.SetInteger("Death_Type", 2);
                }
                else // Play alarmed death animations
                {
                    if (anim1)
                        anim.SetInteger("Death_Type", 3);
                    else
                        anim.SetInteger("Death_Type", 4);
                }
                break;
        }
	}

    public void ThrowDagger(int isLeftArm)
    {
        #region Instantiate Throwing Dagger
        GameObject projectile = Instantiate(Resources.Load<GameObject>("Prefabs/Enemies/Dagger"));
        if (isLeftArm == 0)
            projectile.transform.position = leftHand.transform.position;
        else
            projectile.transform.position = rightHand.transform.position;
        #endregion

        // Add velocity to throwing dagger
        direction = player.transform.position - projectile.transform.position;
        Vector3 throwVector = new Vector3(direction.normalized.x * 100, direction.y, direction.normalized.z * 100);
        projectile.GetComponent<Rigidbody>().velocity = throwVector;
    }

    private void OnDrawGizmosSelected()
    {
        Matrix4x4 rotationMatrix = Matrix4x4.TRS(transform.position, transform.rotation, transform.lossyScale);
        Gizmos.matrix = rotationMatrix;
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(Vector3.zero, (detectionRange/transform.localScale.x));
    }
}
