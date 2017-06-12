using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipBob : MonoBehaviour {
	private float degreeOfRotation;
    private bool isOver;
    private bool isUnder;
	// Use this for initialization
	void Start() 
	{
        isUnder = true;
        isOver = false;
	}
	
	// Update is called once per frame
	void Update() 
	{
		DegreeControl();
	}

	void DegreeControl()
	{
        if (transform.eulerAngles.z < -5)
        {
            isUnder = true;
            isOver = false;
        }

        if (transform.eulerAngles.z > 5)
        {
            isOver = true;
            isUnder = false;
        }


		if (isUnder)
        {
            transform.Rotate(Vector3.forward,Time.deltaTime * 3, Space.Self);
        } 

		if (isOver)
		{
            transform.Rotate(Vector3.forward, -(Time.deltaTime * 3), Space.Self);
        }

	}
}
