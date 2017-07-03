using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roam : MonoBehaviour {
    private bool isInArea;
    private bool isOutOfBounds;
    private bool isTouchingShips;
    private float fishSpeed;
    private int rotateDirection;
	// Use this for initialization

	void Start ()
    {
        fishSpeed = 9;
	}

    // Update is called once per frame
    void Update()
    {
        MovementOfFish();
        RotationOfFish();
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Plank")
        {
            isInArea = true;
            fishSpeed = 15;
            float rng;
            rng = Random.Range(1, 3);
            Debug.Log(rng);
            if (rng == 1)
            {
                rotateDirection = -1;
            }
            else
            {
                rotateDirection = 1;
            }
        }
        if (col.gameObject.name == "BoundsCheck")
        {
            isOutOfBounds = false;
            fishSpeed = 9;
        }

        if (col.gameObject.name == "PirateShip")
        {
            isTouchingShips = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.name == "Plank")
        {
            isInArea = false;
            fishSpeed = 9;
        }
        if (col.gameObject.name == "BoundsCheck")
        {
            isOutOfBounds = true;
            fishSpeed = 12;
        }

		if (col.gameObject.name == "PirateShip")
        {
            isTouchingShips = false;
        }
    }

    void MovementOfFish()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * fishSpeed, Space.Self);
    }

    void RotationOfFish()
    {
        if (isInArea == true)
        {
            transform.Rotate(Vector3.up * Time.deltaTime * 30 * rotateDirection, Space.Self);
        }
        if (isOutOfBounds == true)
        {
            transform.Rotate(Vector3.up * Time.deltaTime * 10, Space.Self);
        }
        if (isTouchingShips == true)
        {
            transform.Rotate(Vector3.up * Time.deltaTime * 40, Space.Self);
        }
    }
}
