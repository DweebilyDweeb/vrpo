using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatControl : MonoBehaviour {

    private KeyCode left, right;
    private KeyCode accelerate, decelerate;
    private KeyCode slowTime, normalTime;
    private float boatSpeed;
	// Use this for initialization
	void Start ()
    {
        left = KeyCode.A;
        right = KeyCode.D;
        accelerate = KeyCode.W;
        decelerate = KeyCode.S;
        slowTime = KeyCode.T;
        normalTime = KeyCode.Y;
        boatSpeed = 10.0f;
	}
	
	// Update is called once per frame
	void Update ()
    {
        BoatSteering();
        BoatMoving();
        BoatSpeedControl();
        TimeSlow();
	}

    private void BoatSteering()
    {
        if (Input.GetKey(left))
        {
            transform.Rotate(-Vector3.up * Time.deltaTime * 30, Space.Self);
        }
        if (Input.GetKey(right))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * 30, Space.Self);
        }
    }

    private void BoatMoving()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * boatSpeed, Space.Self);
    }
    
    private void BoatSpeedControl()
    {
        if (Input.GetKey(accelerate))
        {
            boatSpeed += (Time.deltaTime * 10);
        }
        if (Input.GetKey(decelerate))
        {
            boatSpeed -= (Time.deltaTime * 10);
        }
    }
    
    private void TimeSlow()
    {
        if (Input.GetKey(slowTime))
        {
            Time.timeScale = 0.1f;
        }
        if (Input.GetKey(normalTime))
        {
            Time.timeScale = 1.0f;
        }
    }
}
