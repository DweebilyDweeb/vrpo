using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin_LandHostile : Goblin
{
    public GameObject leftHand, rightHand;
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

    public void ThrowDagger(int isLeftArm)
    {
        float distance = new Vector3(target.transform.position.x - transform.position.x, 0, target.transform.position.z - transform.position.z).magnitude;
        //Debug.Log("Distance: " + distance);
        float height = target.transform.position.y - transform.position.y;

        #region Instantiate Throwing Dagger
        GameObject projectile = Instantiate(Resources.Load<GameObject>("Prefabs/Enemies/Dagger"));
        if (isLeftArm == 0)
            projectile.transform.position = leftHand.transform.position;
        else
            projectile.transform.position = rightHand.transform.position;
        #endregion

        // Add velocity to throwing dagger
        direction = target.transform.position - projectile.transform.position;
        projectile.GetComponent<Rigidbody>().velocity = new Vector3(direction.x * 0.8f, direction.y, direction.z * 0.8f);
        //projectile.GetComponent<Rigidbody>().velocity += new Vector3(0, -5, 0);
        Debug.Log("throwing dagger direction: " + direction);
        Debug.Log("throwing dagger velocity: " + projectile.GetComponent<Rigidbody>().velocity);

        // Add bullet spread to cannonball for some randomness
        //projectile.GetComponent<Rigidbody>().velocity += new Vector3(Random.Range(-0.5f, 0.5f), Random.Range(-0.5f, -0.25f), Random.Range(-0.5f, 0.5f));
    }

    private void OnDrawGizmosSelected()
    {
        Matrix4x4 rotationMatrix = Matrix4x4.TRS(transform.position, transform.rotation, transform.lossyScale);
        Gizmos.matrix = rotationMatrix;
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(Vector3.zero, (detectionRange/transform.localScale.x));
    }
}
