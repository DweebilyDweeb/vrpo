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
        if (currentState != Goblin_FSM.Death)
        {
            anim.SetTrigger("Death");
            currentState = Goblin_FSM.Death;
        }
    }

    public IEnumerator DespawnGoblin()
    {
        yield return new WaitForSeconds(1.0f);
        Destroy(gameObject);
    }
}
