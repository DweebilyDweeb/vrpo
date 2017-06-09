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
        cannonBall = Resources.Load<GameObject>("Prefabs/Cannon/Cannonball");
        rotation_speed = 1.0f;
        velocity = 50;
        inRange = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
        #region Rotate cannon to aim at target
        direction = target.transform.position - transform.position;
        transform.LookAt(target.transform.position);
        #region Limit rotation
        if (transform.localEulerAngles.y > 180 && transform.localEulerAngles.y < 330)
        {
            transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, 330, transform.localEulerAngles.z);
            inRange = false;
        }
        else if (transform.localEulerAngles.y < 180 && transform.localEulerAngles.y > 30)
        {
            transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, 30, transform.localEulerAngles.z);
            inRange = false;
        }
        else if(transform.localEulerAngles.y == 180)
        {
            transform.localEulerAngles = new Vector3(0, 0, 0);
            inRange = false;
        }
        else
            inRange = true;

        if (transform.localEulerAngles.x > 20)
            transform.localEulerAngles = new Vector3(20, transform.localEulerAngles.y, transform.localEulerAngles.z);
        else if (transform.localEulerAngles.x < -45)
            transform.localEulerAngles = new Vector3(-45, transform.localEulerAngles.y, transform.localEulerAngles.z);
        #endregion
        #endregion

            if (atk_timer > 0)
                atk_timer -= Time.deltaTime;
            else
            {
                atk_timer = 2.0f;
                if (inRange)
                    StartCoroutine(FireCannonball());
            }
	}

    IEnumerator FireCannonball()
    {
        float distance = new Vector3(target.transform.position.x - transform.position.x, 0, target.transform.position.z - transform.position.z).magnitude;
        Debug.Log("Distance: " + distance);
        float height = target.transform.position.y - transform.position.y;

        #region Spawn projectile
        Quaternion particleRotate = new Quaternion();
        particleRotate.eulerAngles = new Vector3(transform.Find("Cannon").eulerAngles.x - 90, transform.Find("Cannon").eulerAngles.y, 0);
        Instantiate(Resources.Load<GameObject>("Prefabs/Cannon/CannonSmoke2"), transform.Find("SmokeLocation").transform.position, particleRotate, transform.Find("SmokeLocation").transform);

        yield return new WaitForSeconds(0.25f);

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
