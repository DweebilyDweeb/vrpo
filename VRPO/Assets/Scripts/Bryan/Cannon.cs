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
        //if (Quaternion.Euler(rotation.x, rotation.y, 0f).eulerAngles.y > 270 && Quaternion.Euler(rotation.x, rotation.y, 0f).eulerAngles.y < 345)
        //{
        //    partToRotate.transform.rotation = Quaternion.Euler(rotation.x, 345 + (transform.localEulerAngles.y * 2), 0f);
        //    inRange = HelperFunctions.CheckWithinRange(335, 355, lookRotation.eulerAngles.y);//Quaternion.Euler(rotation.x, rotation.y, 0f).eulerAngles.y);
        //}
        //else if (Quaternion.Euler(rotation.x, rotation.y, 0f).eulerAngles.y < 180 && Quaternion.Euler(rotation.x, rotation.y, 0f).eulerAngles.y > 15)
        //{
        //    partToRotate.transform.rotation = Quaternion.Euler(rotation.x, 15 + (transform.localEulerAngles.y * 2), 0f);
        //    inRange = HelperFunctions.CheckWithinRange(0, 25, Quaternion.Euler(rotation.x, rotation.y, 0f).eulerAngles.y);
        //}
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
        yield return new WaitForSeconds(0.25f);

        GameObject projectile = Instantiate(cannonBall);
        projectile.transform.position = partToRotate.transform.position;
        projectile.transform.eulerAngles = partToRotate.transform.eulerAngles;
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
