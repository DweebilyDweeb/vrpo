using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : MonoBehaviour 
{
    public enum Goblin_FSM { Idle = 1, Walk, Walk_LTurn, Walk_RTurn, Run, Dash, Unsheathe, Attack, Throw, Hit, Death }
    protected Goblin_FSM currentState = Goblin_FSM.Idle;
    protected Animator anim;
	// Use this for initialization
	void Start () 
    {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TriggerDeath()
    {
        anim.SetTrigger("Death");
        Debug.Log("Killed goblin");
    }
}
