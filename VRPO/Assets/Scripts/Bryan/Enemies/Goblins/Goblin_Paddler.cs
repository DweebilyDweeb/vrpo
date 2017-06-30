using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin_Paddler : Goblin 
{

	// Use this for initialization
	void Start () {
        anim = transform.parent.gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () 
    {
        switch (currentState)
        {
            case Goblin_FSM.Death:
                if (!isDead)
                {
                    isDead = true;

                    anim.SetTrigger("Death");
                }
                break;
        }
	}
}
