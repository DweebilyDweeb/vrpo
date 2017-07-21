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
            case "Bird":
                GameObject.FindGameObjectWithTag("GameController").GetComponent<ScoreSystem>().AddScore(10);
                Destroy(collision.gameObject);
                Instantiate(Resources.Load<GameObject>("Prefabs/Animals/Seagull"));
                break;
            case "Cannonball":
                collision.gameObject.GetComponent<Projectile>().DestroyProjectile();
                break;
            case "Piranha":
                GameObject.FindGameObjectWithTag("GameController").GetComponent<ScoreSystem>().AddScore(10);
                Destroy(collision.gameObject);
                break;
            case "Goblin":
                GameObject.FindGameObjectWithTag("GameController").GetComponent<ScoreSystem>().AddScore(50);
                collision.gameObject.GetComponent<Goblin>().TriggerDeath();
                break;
            case "Rope":
                collision.gameObject.GetComponent<Rope>().TriggerCut();
                break;
        }
    }
}
