using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin_Boarder : Goblin
{

	// Use this for initialization
	void Start () 
    {
        currentState = Goblin_FSM.Board;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
