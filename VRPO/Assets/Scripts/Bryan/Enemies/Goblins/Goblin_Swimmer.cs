using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin_Swimmer : Goblin 
{
	// Use this for initialization
	void Start () 
    {
        currentState = Goblin_FSM.Swim;
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
