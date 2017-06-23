using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiranhaSpawn : MonoBehaviour 
{
    public float spawnRadius, spawnRandomness, spawnForwardOffset;
    public int piranhaToSpawn;
    public float piranhaSpeed;
    private Collider triggerZone;
	// Use this for initialization
	void Start () 
    {
        triggerZone = GetComponent<BoxCollider>();
	}
	
	// Update is called once per frame
	void Update () 
    {
		
	}

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.tag == "Boat")
        {
            for(int spawnCount = 0; spawnCount < piranhaToSpawn; spawnCount++)
            {
                bool side = HelperFunctions.RandomBool();
                Vector3 spawnPos = Vector3.zero;
                Vector3 eulerRot;
                if(side) //right
                {
                    spawnPos = new Vector3(spawnRadius + Random.RandomRange(-spawnRandomness, spawnRandomness), -1.5f, spawnForwardOffset + Random.Range(-3, 3));
                    eulerRot = new Vector3(0, -90, 0);
                }
                else //left
                {
                    spawnPos = new Vector3(-spawnRadius + Random.RandomRange(-spawnRandomness, spawnRandomness), -1.5f, spawnForwardOffset + Random.Range(-3, 3));
                    eulerRot = new Vector3(0, 90, 0);
                }
                GameObject piranha = Instantiate(Resources.Load<GameObject>("Prefabs/Animals/Piranha"), transform);
                piranha.transform.localPosition = spawnPos;
                piranha.transform.localEulerAngles = eulerRot;
                piranha.GetComponent<Piranha>().Init(piranhaSpeed, side);
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        Matrix4x4 rotationMatrix = Matrix4x4.TRS(transform.position, transform.rotation, transform.lossyScale);
        Gizmos.matrix = rotationMatrix;
        Gizmos.color = Color.red;
        //Gizmos.DrawWireSphere(Vector3.zero, spawnRadius);
        Gizmos.DrawWireCube(new Vector3(0, 0, spawnForwardOffset), new Vector3(spawnRadius * 2, 0, 6));
    }
}
