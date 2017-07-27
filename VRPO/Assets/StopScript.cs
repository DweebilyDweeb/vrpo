using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class StopScript : MonoBehaviour
{
    Vector3 Stop;

    // Use this for initialization
    void Start()
    {
        Stop = new Vector3(0, 0, 0);
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
            transform.GetComponent<NavMeshAgent>().isStopped = true;
            transform.GetComponent<NavMeshAgent>().velocity = Stop;
        }
    }

}
