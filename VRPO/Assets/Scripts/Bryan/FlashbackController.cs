using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashbackController : MonoBehaviour 
{
    public static float gameTimer = 0.0f;

    public float timer, tentacleDelay;
    public GameObject kraken, FB_tentacles;

    private bool animTriggered = false;
	// Use this for initialization
	void Start () 
    {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
        gameTimer += Time.deltaTime;

        if (gameTimer > timer)
        {
            if (!animTriggered)
            {
                animTriggered = true;
                StartCoroutine(TriggerAnim(tentacleDelay));
            }
        }
	}

    IEnumerator TriggerAnim(float delay)
    {
        kraken.GetComponent<Animator>().SetTrigger("Atk_Horizontal");

        yield return new WaitForSeconds(delay);

        for (int i = 0; i < FB_tentacles.transform.childCount; i++)
        {
            FB_tentacles.transform.GetChild(i).GetComponent<Animator>().SetTrigger("Attack");
        }
    }
}
