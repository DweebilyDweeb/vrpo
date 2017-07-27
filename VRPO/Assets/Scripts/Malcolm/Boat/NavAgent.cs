using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavAgent : MonoBehaviour {

    public Transform target;
    NavMeshAgent agent;

	// Use this for initialization
	void Start ()
    {
        agent = GetComponent<NavMeshAgent>();
    
        GetComponent<NavMeshAgent>().SetDestination(target.position);
	}
	
	// Update is called once per frame
	void Update() { 
	}
}
