using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour 
{
    private GameObject target, cannonBall;
    private Vector3 direction;
    private float velocity, rotation_speed;
    private float atk_timer = 2.0f;
    private bool inRange;

	// Use this for initialization
	void Start () 
    {
        target = GameObject.FindGameObjectWithTag("Player");
        cannonBall = Resources.Load<GameObject>("Prefabs/Cannonball");
        rotation_speed = 1.0f;
        velocity = 50;
        inRange = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
        #region Rotate cannon to aim at target
        direction = target.transform.position - transform.position;
        Quaternion targetRotation = Quaternion.LookRotation(direction.normalized);

        #region Account for min/max rotation
        float clamped_X = HelperFunctions.ClampAngle(targetRotation.eulerAngles.x, -45, 20);
        float clamped_Y = HelperFunctions.ClampAngle(targetRotation.eulerAngles.y, -30, 30);

        Quaternion adjustedRotation = new Quaternion(0,0,0,0);
        adjustedRotation.eulerAngles = new Vector3(clamped_X, clamped_Y, targetRotation.eulerAngles.z);

        if (adjustedRotation.eulerAngles == targetRotation.eulerAngles)
            inRange = true;
        else
            inRange = false;
        #endregion

        transform.rotation = Quaternion.Slerp(transform.rotation, adjustedRotation, Time.deltaTime * rotation_speed);
        #endregion

        if (atk_timer > 0)
            atk_timer -= Time.deltaTime;
        else
        {
            if(inRange)
                FireCannonball();
            atk_timer = 2.0f;
        }
	}

    void FireCannonball()
    {
        float distance = new Vector3(target.transform.position.x - transform.position.x, 0, target.transform.position.z - transform.position.z).magnitude;
        Debug.Log("Distance: " + distance);
        float height = target.transform.position.y - transform.position.y;

        #region Spawn projectile
        GameObject projectile = Instantiate(cannonBall);
        projectile.transform.position = transform.position;
        projectile.transform.rotation = transform.rotation;
        #endregion

        // Add velocity to cannonball
        projectile.GetComponent<Rigidbody>().velocity = projectile.transform.forward * velocity;
        projectile.GetComponent<Rigidbody>().AddForce(0, 45, 0); // Aim it upwards a little to compensate for gravity
        Debug.Log("Cannonball velocity before bulletspread: " + projectile.GetComponent<Rigidbody>().velocity);

        // Add bullet spread to cannonball
        //projectile.GetComponent<Rigidbody>().velocity += new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f));
        //Debug.Log("Cannonball velocity after bulletspread: " + projectile.GetComponent<Rigidbody>().velocity);
    }
}
