using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour {
    private int Score;
    public Text scoreText;
    public GameObject scoreModList;
    public List<GameObject> scoreModifiers = new List<GameObject>();

    public bool scoreModSpawned = false;

    public int GetScore() { return Score; }
    public void SetScore(int newScore) { Score = newScore; }
    public void ModifyScore(int value) { if ((Score + value) < 0) { Score = 0; } else { Score += value; } }

    // Use this for initialization
    void Start()
    {
        Score = 0;
    }

    void Update()
    {
        scoreText.text = Score.ToString();

        if(scoreModifiers.Count > 0)
        {
            if (!scoreModSpawned)
            {
                scoreModSpawned = true;
                Instantiate<GameObject>(scoreModifiers[0], scoreModList.transform);
            }
        }
    }

    public void AddScore(int value)
    {
        GameObject scoreMod = Resources.Load<GameObject>("Prefabs/Player/Score_Mod");
        scoreMod.GetComponent<Score_Mod>().Init(value);
        scoreModifiers.Add(scoreMod);
    }
}
