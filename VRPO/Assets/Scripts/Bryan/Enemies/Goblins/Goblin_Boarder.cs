using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin_Boarder : Goblin
{
    public bool isRightSide;
	// Use this for initialization
	void Start () 
    {
        currentState = Goblin_FSM.Board;
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnCollisionEnterChild(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Player":
                break;
        }
    }
}
