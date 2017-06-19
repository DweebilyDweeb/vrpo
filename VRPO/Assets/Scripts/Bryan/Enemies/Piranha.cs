﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piranha : MonoBehaviour 
{
    private GameObject target;
    private float distance, velocity;
    private float lifetime = 5.0f;
    private bool isRightSide, inJumpRange, hasJumped;
    
	// Use this for initialization
    
    void Start () 
    {
        target = GameObject.FindGameObjectWithTag("Boat");
        inJumpRange = false;
        hasJumped = false;
	}

    public void Init(float vel, bool onRightSide)
    {
        velocity = vel;
        isRightSide = onRightSide;
    }
	
	// Update is called once per frame
    void Update()
    {
        distance = new Vector3(target.transform.position.x - transform.position.x, 0, target.transform.position.z - transform.position.z).magnitude;
        //Debug.Log("distance from boat: " + distance);
        if (distance < 12 && !inJumpRange && !hasJumped)
            inJumpRange = true;

        if(inJumpRange)
        {
            if (!hasJumped)
            {
                hasJumped = true;
                transform.localRotation = Quaternion.Lerp(transform.localRotation, Quaternion.Euler(-45, transform.localEulerAngles.y, 0), 1.0f);
            }
            else
            {
                Vector3 newRot = transform.localEulerAngles;
                newRot.x += Time.deltaTime * (velocity * 4);
                transform.localRotation = Quaternion.Euler(newRot);
            }
        }

        transform.position += transform.forward * Time.deltaTime * velocity;

        if (lifetime > 0)
            lifetime -= Time.deltaTime;
        else
            Destroy(gameObject);
	}
}
