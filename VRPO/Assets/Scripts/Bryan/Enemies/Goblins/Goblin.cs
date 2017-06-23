using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : MonoBehaviour 
{
    public enum Goblin_FSM { Idle = 1, Walk, Run, Unsheathe, Swim, Dive, Board, Attack, Throw, Hit, Death }
    protected Goblin_FSM currentState = Goblin_FSM.Idle;
    protected Animator anim;
    protected bool isDead = false;
	// Use this for initialization
	void Start () 
    {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public virtual void TriggerDeath()
    {
        if (currentState != Goblin_FSM.Death)
            currentState = Goblin_FSM.Death;
    }

    public virtual IEnumerator DespawnGoblin()
    {
        yield return new WaitForSeconds(1.0f);
        Destroy(gameObject);
    }
}
