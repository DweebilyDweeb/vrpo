using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatControl : MonoBehaviour {

    private KeyCode left, right;
    private KeyCode accelerate, decelerate;
    private KeyCode slowTime, normalTime;
    private float boatSpeed;
    private bool slowMo;
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
        slowMo = false;
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
            slowMo = true;
            Time.timeScale = 0.3f;
        }
        if (Input.GetKey(normalTime))
        {
            slowMo = false;
        }

        if (slowMo == true)
        {
            if (Time.timeScale > 0.1f)
            {
                Time.timeScale -= Time.deltaTime;
            }
        }
        if (slowMo == false)
        {
            if (Time.timeScale < 1.0f)
            {
                Time.timeScale += Time.deltaTime * 5.0f;
            }
            if (Time.timeScale > 1.0f)
            {
                Time.timeScale = 1.0f;
            }
        }

    }
}
