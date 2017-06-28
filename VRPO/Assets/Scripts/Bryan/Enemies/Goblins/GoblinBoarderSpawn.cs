using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinBoarderSpawn : MonoBehaviour 
{
    public int goblinsToSpawn;
    public float goblinSwimSpeed, spawnDistance, spreadDistance;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Boat")
        {
            for (int spawnCount = 0; spawnCount < goblinsToSpawn; spawnCount++)
            {
                bool side = HelperFunctions.RandomBool();
                Vector3 spawnPos = Vector3.zero;
                Vector3 eulerRot = new Vector3(0, 180, 0);
                if (side) //right
                    spawnPos = new Vector3(-spreadDistance + Random.Range(-spreadDistance, spreadDistance), 0, spawnDistance + Random.Range(-5, 5));
                else //left
                    spawnPos = new Vector3(spreadDistance + Random.Range(-spreadDistance, spreadDistance), -1.5f, spawnDistance + Random.Range(-5, 5));

                GameObject goblin = Instantiate(Resources.Load<GameObject>("Prefabs/Enemies/Goblin_Swimmer"), transform);
                goblin.transform.localPosition = spawnPos;
                goblin.transform.localEulerAngles = eulerRot;
                goblin.GetComponent<Goblin_Swimmer>().Init(side, goblinSwimSpeed);
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        Matrix4x4 rotationMatrix = Matrix4x4.TRS(transform.position, transform.rotation, transform.lossyScale);
        Gizmos.matrix = rotationMatrix;
        Gizmos.color = Color.red;
        //Gizmos.DrawWireSphere(Vector3.zero, spawnRadius);
        Gizmos.DrawLine(new Vector3(-(spreadDistance * 2), 0, spawnDistance), new Vector3((spreadDistance * 2), 0, spawnDistance));
    }
}
