using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin_LandHostile : Goblin
{
    public float detectionRange;
    private bool inRange;
    private GameObject target;
    private Vector3 direction;

	// Use this for initialization
	void Start () 
    {
        anim = GetComponent<Animator>();
        target = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (new Vector3(target.transform.position.x - transform.position.x, 0, target.transform.position.z - transform.position.z).magnitude < detectionRange)
            inRange = true;
        if (inRange)
        {
            transform.LookAt(target.transform);
            direction = target.transform.position - transform.position;

            if (currentState == Goblin_FSM.Idle || currentState == Goblin_FSM.Walk)
                currentState = Goblin_FSM.Unsheathe;
        }
		switch(currentState)
        {
            case Goblin_FSM.Idle:
                break;
            case Goblin_FSM.Unsheathe:
                anim.SetTrigger("Unsheathe");
                break;
            case Goblin_FSM.Throw:
                anim.SetTrigger("Throw");
                break;
        }
	}

    public void ThrowDagger()
    {
        float distance = new Vector3(target.transform.position.x - transform.position.x, 0, target.transform.position.z - transform.position.z).magnitude;
        //Debug.Log("Distance: " + distance);
        float height = target.transform.position.y - transform.position.y;
        
        GameObject projectile = Instantiate(Resources.Load<GameObject>("Prefabs/Objects/Dagger"));

        // Add velocity to cannonball
        #region Old Method
        //projectile.GetComponent<Rigidbody>().velocity = projectile.transform.forward * velocity;
        //projectile.GetComponent<Rigidbody>().AddForce(0, 45, 0); // Aim it upwards a little to compensate for gravity
        #endregion

        if (distance > 400)
        {
            direction = HelperFunctions.MultiplyVector3(direction, new Vector3(0.125f, 0.125f, 0.125f));
            //Debug.Log("distance > 200, adjusted to : " + direction);
        }
        else if (distance > 200)
        {
            direction = HelperFunctions.MultiplyVector3(direction, new Vector3(0.25f, 0.25f, 0.25f));
            //Debug.Log("distance > 200, adjusted to : " + direction);
        }
        else if (distance > 100)
        {
            direction = direction / 2;
            //Debug.Log("distance > 100, adjusted to : " + direction);
        }

        projectile.GetComponent<Rigidbody>().velocity = direction;

        // Add bullet spread to cannonball for some randomness
        projectile.GetComponent<Rigidbody>().velocity += new Vector3(Random.Range(-0.5f, 0.5f), Random.Range(-0.5f, -0.25f), Random.Range(-0.5f, 0.5f));
    }

    private void OnDrawGizmosSelected()
    {
        Matrix4x4 rotationMatrix = Matrix4x4.TRS(transform.position, transform.rotation, transform.lossyScale);
        Gizmos.matrix = rotationMatrix;
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(Vector3.zero, detectionRange);
    }
}
