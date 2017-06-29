using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
    {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
		
	}

    private void OnTriggerEnter(Collider collision)
    {
        switch(collision.gameObject.tag)
        {
            case "Cannonball":
                collision.gameObject.GetComponent<Projectile>().DestroyProjectile();
                break;
            case "Goblin":
                GameObject.FindGameObjectWithTag("GameController").GetComponent<ScoreSystem>().AddScore(500);
                collision.gameObject.GetComponent<Goblin>().TriggerDeath();
                break;
        }
    }
}
