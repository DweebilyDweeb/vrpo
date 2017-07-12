using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatScriptedMovement : MonoBehaviour {
    float boatMovementSpeed;
    float boatMaxMovementSpeed;
    float boatRotateSpeed;

    bool IsLeftTurn;
    bool IsRightTurn;
    bool IsRotationAccelerate;
    bool IsRotationDecelerate;
    public bool isLeftOccupied, isRightOccupied, isBackOccupied; // For goblin boarders
	// Use this for initialization
	void Start ()
    {
        boatMovementSpeed = 0;
        boatRotateSpeed = 0;
        boatMaxMovementSpeed = 5;
        IsLeftTurn = false;
        IsRightTurn = false;
        IsRotationAccelerate = false;
        IsRotationDecelerate = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
        MovementOfBoat();
        RotationOfBoat();
    }
    
    void MovementOfBoat()
    {
        if (boatMovementSpeed < boatMaxMovementSpeed)
        {
            boatMovementSpeed += Time.deltaTime;
        }
        else if (boatMovementSpeed > boatMaxMovementSpeed)
        {
            boatMovementSpeed = boatMaxMovementSpeed;
        }
        transform.Translate(Vector3.forward * Time.deltaTime * boatMovementSpeed * 1.2f, Space.Self);
    }

    void RotationOfBoat()
    {
        if (IsLeftTurn == true)
        {
            transform.Rotate(-Vector3.up * Time.deltaTime * boatRotateSpeed, Space.Self);
        }
        if (IsRightTurn == true)
        {
            transform.Rotate(Vector3.up * Time.deltaTime * boatRotateSpeed, Space.Self);
        }
        if (IsRotationDecelerate == true)
        {
            DecelerationOfRotation();
        }
        if (IsRotationAccelerate == true)
        {
            AccelerationOfRotation();
        }
    }
    
    void AccelerationOfRotation()
    {
        if (boatRotateSpeed < 15)
        {
            boatRotateSpeed += Time.deltaTime * 3;
        }

    }
    
    void DecelerationOfRotation()
    {
        if (boatRotateSpeed > 0)
        {
            boatRotateSpeed -= Time.deltaTime * 5;
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "LeftTurn")
        {
            IsLeftTurn = true;
            IsRotationAccelerate = true;
            IsRotationDecelerate = false;
        }
        if (col.gameObject.name == "RightTurn")
        {
            IsRightTurn = true;
            IsRotationAccelerate = true;
            IsRotationDecelerate = false;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.name == "LeftTurn")
        {
            IsLeftTurn = false;
            IsRotationDecelerate = true;
            IsRotationAccelerate = false;
        }
        if (col.gameObject.name == "RightTurn")
        {
            IsRightTurn = false;
            IsRotationDecelerate = true;
            IsRotationAccelerate = false;
        }
    }
}
