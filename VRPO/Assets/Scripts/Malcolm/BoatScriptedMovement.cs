using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatScriptedMovement : MonoBehaviour {
    float boatMovementSpeed;
    float boatRotateSpeed;

    bool IsLeftTurn;
    bool IsRightTurn;
	// Use this for initialization
	void Start ()
    {
        boatMovementSpeed = 10;
        boatRotateSpeed = 0;
        IsLeftTurn = false;
        IsRightTurn = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
        MovementOfBoat();
        RotationOfBoat();
    }
    
    void MovementOfBoat()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * boatMovementSpeed, Space.Self);
    }

    void RotationOfBoat()
    {
        if (IsLeftTurn == true)
        {
            transform.Rotate(-Vector3.up * Time.deltaTime * boatRotateSpeed, Space.Self);
            if (boatRotateSpeed < 15)
            {
                boatRotateSpeed += Time.deltaTime * 3;
                Debug.Log(boatRotateSpeed);
            }
        }
        if (IsRightTurn == true)
        {
            transform.Rotate(Vector3.up * Time.deltaTime * boatRotateSpeed, Space.Self);
            if (boatRotateSpeed < 15)
            {
                boatRotateSpeed += Time.deltaTime * 3;
                Debug.Log(boatRotateSpeed);
            }
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "LeftTurn")
        {
            IsLeftTurn = true;
        }
        if (col.gameObject.name == "RightTurn")
        {
            IsRightTurn = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.name == "LeftTurn")
        {
            IsLeftTurn = false;
            boatRotateSpeed = 0;
        }
        if (col.gameObject.name == "RightTurn")
        {
            IsRightTurn = false;
            boatRotateSpeed = 0;
        }
    }
}
