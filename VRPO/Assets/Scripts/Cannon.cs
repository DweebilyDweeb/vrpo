using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour 
{
    private GameObject target, cannonBall;
    private Vector3 direction;
    private float velocity, rotation_speed;
    private float atk_timer = 2.0f;

	// Use this for initialization
	void Start () 
    {
        target = GameObject.Find("PlayerCharacter");
        cannonBall = Resources.Load<GameObject>("Prefabs/Cannonball");
        rotation_speed = 1.0f;
        velocity = 50;   //(((target.transform.position - transform.position).magnitude + 0.1f) * 9.8f);
	}
	
	// Update is called once per frame
	void Update ()
    {
        direction = target.transform.position - transform.position;
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction.normalized), Time.deltaTime * rotation_speed);

        if (atk_timer > 0)
            atk_timer -= Time.deltaTime;
        else
        {
            FireCannonball();
            atk_timer = 2.0f;
        }
	}

    void FireCannonball()
    {
        float distance = new Vector3(target.transform.position.x - transform.position.x, 0, target.transform.position.z - transform.position.z).magnitude;
        float height = target.transform.position.y - transform.position.y;

        #region Spawn projectile
        GameObject projectile = Instantiate(cannonBall);
        projectile.transform.position = transform.position;
        projectile.transform.rotation = transform.rotation;
        Debug.Log("cannonball position: " + projectile.transform.position);

        Vector3 dirVec;
        #region Calculate direction vector for cannonball (Mortar)
        //float angle = Mathf.Atan((velocity * velocity + Mathf.Sqrt((velocity * velocity * velocity * velocity) - 9.8f * ((9.8f * distance * distance) + (2 * height * velocity * velocity)))) / (9.8f * distance));
        float angle = 0.5f * Mathf.Asin((Physics.gravity.magnitude * distance) / (velocity * velocity));

        float velocity_XZ = Mathf.Cos(angle);
        float velocity_Y = Mathf.Sin(angle);
        dirVec.x = direction.normalized.x * velocity_XZ * velocity;
        dirVec.y = velocity_Y * velocity;
        dirVec.z = direction.normalized.z * velocity_XZ * velocity;
        Debug.Log("angle = " + angle);
        Debug.Log("direction = " + direction);
        Debug.Log("velocity_Y = " + velocity_Y);
        Debug.Log("dirVec = " + dirVec);
        #endregion
        // Add velocity to cannonball
        projectile.GetComponent<Rigidbody>().velocity = projectile.transform.forward * velocity;
        projectile.GetComponent<Rigidbody>().AddForce(0, 40, 0);

        //dirVec = BallisticVel(target.transform, CalculateAngle());
        
        //projectile.GetComponent<Rigidbody>().velocity = dirVec;
        #endregion
    }

    Vector3 BallisticVel(Transform target, float angle)
    {
        var dir = target.position - transform.position;  // get target direction
        var h = dir.y;  // get height difference
        dir.y = 0;  // retain only the horizontal direction
        var dist = dir.magnitude ;  // get horizontal distance
        var a = angle * Mathf.Deg2Rad;  // convert angle to radians
        dir.y = dist * Mathf.Tan(a);  // set dir to the elevation angle
        dist += h / Mathf.Tan(a);  // correct for small height differences
        // calculate the velocity magnitude
        Debug.Log("dist: " + dist);
        float arc = Physics.gravity.magnitude / Mathf.Sin(2 * a);
        if (arc < 0)
            arc = arc * -1;
        var vel = Mathf.Sqrt(dist * arc);
        Debug.Log("vel: " + Mathf.Sin(2 * a));
        return vel * dir.normalized;
    }

    float CalculateAngle()
    {
        Vector3 dir = target.transform.position - transform.position;
        Vector3 dirH = new Vector3(dir.x, 0, dir.y);
        // measure the unsigned angle between them:
        float angle = Vector3.Angle(dir, dirH);
        // add the signal (negative is below the cannon):

        float offset = 10;
        if (dir.y < 0)
            angle = -angle + offset;
        else
            angle += offset;


        return angle;
    }
}
