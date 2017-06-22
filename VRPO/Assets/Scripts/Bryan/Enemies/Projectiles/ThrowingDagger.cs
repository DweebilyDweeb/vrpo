using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowingDagger : Projectile
{
    private Animator anim;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Player":
                collision.gameObject.GetComponent<Player>().AddHP(-1);
                Destroy(gameObject);
                break;
            case "Terrain":
                SetDaggerIdle();
                Destroy(gameObject, 5.0f);
                break;
            case "Water":
                // Spawn particle effects
                Destroy(gameObject, 5.0f);
                break;
        }
    }

    private void SetDaggerIdle()
    {
        anim.SetTrigger("Idle");
        GetComponent<Rigidbody>().freezeRotation = false;
    }
}
