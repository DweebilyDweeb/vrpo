using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin_Boarder : Goblin
{
    private bool isBoarding;
    private string side;
    private GameObject boat, player;
    private Vector3 spawnPos;
	// Use this for initialization
	public void Init(string sideBoarded) 
    {
        isBoarding = true;
        side = sideBoarded;
        anim = GetComponent<Animator>();
        boat = GameObject.FindGameObjectWithTag("Boat");
        player = GameObject.FindGameObjectWithTag("Player");
	}

    public void SpawnBoarder()
    {
        switch(side)
        {
            case "Right":
                {
                    boat.GetComponent<BoatScriptedMovement>().isRightOccupied = true;
                    transform.parent = boat.transform;
                    transform.localPosition = new Vector3(277.8f * 0.01f, -1000 * 0.01f, 0);
                    Vector3 localRot = new Vector3(0, -90, 0);
                    transform.localRotation = Quaternion.Euler(localRot);
                }
                break;
            case "Left":
                {
                    boat.GetComponent<BoatScriptedMovement>().isLeftOccupied = true;
                    transform.parent = boat.transform;
                    transform.localPosition = new Vector3(-277.8f * 0.01f, -1000 * 0.01f, 0);
                    Vector3 localRot = new Vector3(0, 90, 0);
                    transform.localRotation = Quaternion.Euler(localRot);
                }
                break;
            case "Back":
                {
                    boat.GetComponent<BoatScriptedMovement>().isBackOccupied = true;
                    transform.parent = boat.transform;
                    transform.localPosition = new Vector3(0, -1000 * 0.01f, -490 * 0.01f);
                    Vector3 localRot = Vector3.zero;
                    transform.localRotation = Quaternion.Euler(localRot);
                }
                break;
        }
    }
	
	// Update is called once per frame
	void Update () 
    {
		switch(currentState)
        {
            case Goblin_FSM.Death:
                if (!isDead)
                {
                    isDead = true;

                    anim.SetTrigger("Death");
                    
                    bool anim1 = HelperFunctions.RandomBool();
                    if (anim1)
                        anim.SetInteger("Death_Type", 1);
                    else
                        anim.SetInteger("Death_Type", 2);
                }
                break;
        }
	}
    
    public void TriggerBoarding()
    {
        transform.localPosition += new Vector3(0, 900 * 0.01f, 0);
        anim.SetTrigger("Board");
        if(!ParrotScriptedDialogue.instance.pirateBoarder)
            ParrotScriptedDialogue.instance.SwitchState(ParrotScriptedDialogue.State.pirateOnShip);
    }

    public void TriggerAttack()
    {
        isBoarding = false;
        anim.SetBool("isBoarding", isBoarding);
    }

    private void UnoccupySide()
    {
        switch(side)
        {
            case "Right":
                boat.GetComponent<BoatScriptedMovement>().isRightOccupied = false;
                break;
            case "Left":
                boat.GetComponent<BoatScriptedMovement>().isLeftOccupied = false;
                break;
            case "Back":
                boat.GetComponent<BoatScriptedMovement>().isBackOccupied = false;
                break;
        }
    }

    public override IEnumerator DespawnGoblin()
    {
        UnoccupySide();
        yield return new WaitForSeconds(1.0f);
        Destroy(gameObject);
    }

    public void AttackPlayer()
    {
        GameObject.FindGameObjectWithTag("GameController").GetComponent<ScoreSystem>().AddScore(-10);
    }

    public void OnCollisionEnterChild(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Player":
                break;
        }
    }
}
