using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    private int HP;

    public int GetHP() { return HP; }
    public void SetHP(int newHP) { HP = newHP; if (HP <= 0) { GameController.gameOver = true; } }
    public void AddHP(int value) { HP += value; if (HP <= 0) { GameController.gameOver = true; } Debug.Log("Player HP = " + HP); }
	// Use this for initialization
	void Start () {
        HP = 3;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
