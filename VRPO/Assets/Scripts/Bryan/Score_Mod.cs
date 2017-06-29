using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_Mod : MonoBehaviour 
{
    public int scoreToAdd;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Init(int value)
    {
        scoreToAdd = value;

        string temp = "";
        if (value > 0)
            temp = "+" + value;
        else
            temp = value.ToString();

        GetComponent<Text>().text = temp;
    }

    private void IncreaseScore()
    {
        GameObject.FindGameObjectWithTag("GameController").GetComponent<ScoreSystem>().ModifyScore(scoreToAdd);
        GameObject.FindGameObjectWithTag("GameController").GetComponent<ScoreSystem>().scoreModSpawned = false;
        DestroyScoreMod();
    }

    private void DestroyScoreMod()
    {
        GameObject.FindGameObjectWithTag("GameController").GetComponent<ScoreSystem>().scoreModifiers.RemoveAt(0);
        Destroy(gameObject);
    }
}
