using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour 
{
    public GameObject partToRotate, cannonBarrel, cannonBall, smokeParticles, smokeLocation;

    private GameObject target;
    private Vector3 direction;
    private float velocity, rotation_speed;
    private float atk_timer = 2.0f;
    private bool inRange;
	private AudioSource audio;
	// Use this for initialization
	void Start () 
    {
        target = GameObject.FindGameObjectWithTag("Player");
        rotation_speed = 2.0f;
        velocity = 50;
        inRange = true;
		audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        #region Rotate cannon to aim at target
        direction = target.transform.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(direction);
        Vector3 rotation = Quaternion.Lerp(partToRotate.transform.rotation, lookRotation, Time.deltaTime * rotation_speed).eulerAngles;
        partToRotate.transform.rotation = Quaternion.Euler(rotation.x, rotation.y, 0f);
        #region Limit rotation
        // x-rotation
        if (partToRotate.transform.localEulerAngles.x < 180 && partToRotate.transform.localEulerAngles.x > 10)
        {
            partToRotate.transform.localEulerAngles = new Vector3(10, partToRotate.transform.localEulerAngles.y, 0);
            inRange = false;
        }
        else if (partToRotate.transform.localEulerAngles.x > 180 && partToRotate.transform.localEulerAngles.x < 350)
        {
            partToRotate.transform.localEulerAngles = new Vector3(350, partToRotate.transform.localEulerAngles.y, 0);
            inRange = false;
        }

        // y-rotation
        if(partToRotate.transform.localEulerAngles.y < 180 && partToRotate.transform.localEulerAngles.y > 10)
        {
            partToRotate.transform.localEulerAngles = new Vector3(partToRotate.transform.localEulerAngles.x, 10, 0);
            inRange = false;
        }
        else if (partToRotate.transform.localEulerAngles.y > 180 && partToRotate.transform.localEulerAngles.y < 350)
        {
            partToRotate.transform.localEulerAngles = new Vector3(partToRotate.transform.localEulerAngles.x, 350, 0);
            inRange = false;
        }
        else if (partToRotate.transform.localEulerAngles.y == 180)
        {
            partToRotate.transform.localEulerAngles = new Vector3(0, 0, 0);
            inRange = false;
        }
        else
        {
            inRange = true;
        }
        #endregion
        #endregion

        if (atk_timer > 0)
            atk_timer -= Time.deltaTime;
        else
        {
            atk_timer = 2.0f;
            if (inRange)
            {
                StartCoroutine(FireCannonball());
            }
        }
	}

    IEnumerator FireCannonball()
    {
        float distance = new Vector3(target.transform.position.x - transform.position.x, 0, target.transform.position.z - transform.position.z).magnitude;
        Debug.Log("Distance: " + distance);
        float height = target.transform.position.y - transform.position.y;

        #region Spawn projectile
        Quaternion particleRotate = new Quaternion();
        particleRotate.eulerAngles = new Vector3(cannonBarrel.transform.eulerAngles.x, cannonBarrel.transform.eulerAngles.y, 0);
        Instantiate(smokeParticles, smokeLocation.transform.position, particleRotate, smokeLocation.transform);
        audio.Play();
        yield return new WaitForSeconds(0.1f);

        GameObject projectile = Instantiate(cannonBall);
        projectile.transform.position = partToRotate.transform.position;
        projectile.transform.eulerAngles = partToRotate.transform.eulerAngles;
		#endregion

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
        projectile.GetComponent<Rigidbody>().velocity += new Vector3(Random.Range(-0.25f, 0.25f), Random.Range(-0.25f, 0.25f), Random.Range(-0.25f, 0.25f));
    }
}
