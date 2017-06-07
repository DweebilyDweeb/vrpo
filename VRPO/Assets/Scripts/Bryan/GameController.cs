using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour 
{
    public static float gameTimer = 0.0f;
    public static bool gameOver = false;
    public static bool isPaused = false;

    private int shipCount = 0;
    private float defaultSpawnTimer = 30.0f;
    private float shipSpawnTimer;
	// Use this for initialization
	void Start () 
    {
        SpawnShip(); // Spawn 1st ship
		shipSpawnTimer = defaultSpawnTimer; // Set countdown for next ship's spawn
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (!isPaused)
        {
            gameTimer += Time.deltaTime;
            shipSpawnTimer -= Time.deltaTime;

            if(shipSpawnTimer < 0)
            {
                if(shipCount < 5)
                    SpawnShip();
                shipSpawnTimer = defaultSpawnTimer;
            }
        }

        if(gameOver)
        {
            //Go to game over scene
        }
	}

    void SpawnShip()
    {
        shipCount++;
        // Instantiate ship
    }
}
