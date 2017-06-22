using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin_ChildCollider : Goblin 
{
    public Goblin_Swimmer parentScript_S;
    public Goblin_Boarder parentScript_B;
	// Use this for initialization
	void Start () 
    {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (parentScript_S != null)
            parentScript_S.OnCollisionEnterChild(collision);
        else if (parentScript_B != null)
            parentScript_B.OnCollisionEnterChild(collision);
    }

    public override void TriggerDeath()
    {
        if (parentScript_S != null)
            parentScript_S.TriggerDeath();
        else if (parentScript_B != null)
            parentScript_B.TriggerDeath();
    }
}
