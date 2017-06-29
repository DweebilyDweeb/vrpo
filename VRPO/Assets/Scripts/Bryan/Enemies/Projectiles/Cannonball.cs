using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannonball : Projectile
{
	// Use this for initialization
	void Start () {
        lifetime = 20.0f;
	}
	
	// Update is called once per frame
	public override void Update () {
        if (lifetime > 0)
            lifetime -= Time.deltaTime;
        else
            Destroy(gameObject);

        if (lifetime < 24)
            GetComponent<Rigidbody>().useGravity = true;
	}

    public override void DestroyProjectile()
    {
        Instantiate(Resources.Load<GameObject>("Prefabs/Particle Effects/CannonSmoke2"), gameObject.transform.position, new Quaternion(0, 0, 0, 0));
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        switch(collision.gameObject.tag)
        {
            case "Player":
                GameObject.FindGameObjectWithTag("GameController").GetComponent<ScoreSystem>().AddScore(-100);
                Destroy(gameObject);
                break;
            case "Terrain":
                // Spawn particle effects
                Destroy(gameObject, 5.0f);
                break;
            case "Water":
                // Spawn particle effects
                Destroy(gameObject, 5.0f);
                break;
            case "Cannonball":
                Instantiate(Resources.Load<GameObject>("Prefabs/Particle Effects/CannonSmoke2"), gameObject.transform.position, new Quaternion(0, 0, 0, 0));
                GetComponent<Rigidbody>().useGravity = true;
                break;
        }

        //if (collision.gameObject.name == "Terrain")
        //{
        //    Collider[] inrange = Physics.OverlapSphere(transform.position, Explosion_radius, LayerMask.GetMask("Monster"));
        //    foreach (Collider enemy in inrange)
        //    {
        //        //Health mobHealth = enemy.transform.GetComponent<Health>();
        //        //if (mobHealth != null)
        //        //{
        //        //    mobHealth.DecreaseHealth(Random.Range(minDamage, maxDamage));
        //        //}
        //    }
        //    Destroy(this.gameObject);
        //    GameObject temp = Instantiate(radius);
        //    temp.transform.position = transform.position;
        //    temp.transform.localScale = new Vector3(Explosion_radius * 2, 1.0f, Explosion_radius * 2);
        //    Debug.Log(temp.transform.localScale);
        //    Destroy(temp, 0.1f);
        //}
        //if (collision.gameObject.tag == "Grid")
        //{
        //    Destroy(this.gameObject);
        //}
    }
}
