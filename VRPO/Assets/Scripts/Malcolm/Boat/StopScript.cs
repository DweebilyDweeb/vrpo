using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class StopScript : MonoBehaviour
{
    float normalAcceleration, stopAcceleration;
    NavMeshAgent boat;
    // Use this for initialization
    void Start()
    {
        boat = GetComponent<NavMeshAgent>();
        normalAcceleration = 1;
        stopAcceleration = 10;
        StopBoat();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Stop")
        {
            Debug.Log("Stop");
            StopBoat();
            col.gameObject.SetActive(false);
        }
    }

    public void StopBoat()
    {
        boat.isStopped = true;
        boat.acceleration = stopAcceleration;
    }

    public void StartBoat()
    {
        boat.isStopped = false;
        boat.acceleration = normalAcceleration;
    }
}
