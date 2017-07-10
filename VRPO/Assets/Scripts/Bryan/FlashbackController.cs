using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashbackController : MonoBehaviour 
{
    public static float gameTimer = 0.0f;
    public static bool isPaused = false;

    public float timer;
    public GameObject kraken, FB_tentacles;

    private bool animTriggered = false;
	// Use this for initialization
	void Start () 
    {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (!isPaused)
        {
            gameTimer += Time.deltaTime;

            if(gameTimer > timer)
            {
                if (!animTriggered)
                {
                    animTriggered = true;

                    kraken.GetComponent<Animator>().SetTrigger("Atk_Horizontal");
                    for (int i = 0; i < FB_tentacles.transform.childCount; i++)
                    {
                        FB_tentacles.transform.GetChild(i).GetComponent<Animator>().SetTrigger("Attack");
                    }
                }
            }
        }
	}
}
