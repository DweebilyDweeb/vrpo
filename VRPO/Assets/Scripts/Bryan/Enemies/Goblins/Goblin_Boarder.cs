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

    public void SpawnBoarder(string side)
    {
        switch(side)
        {
            case "Right":
                {
                    boat.GetComponent<BoatScriptedMovement>().isRightOccupied = true;
                    transform.parent = boat.transform;
                    transform.localPosition = new Vector3(277.8f, -300, 0);
                    Vector3 localRot = new Vector3(0, -90, 0);
                    transform.localRotation = Quaternion.Euler(localRot);
                }
                break;
            case "Left":
                {
                    boat.GetComponent<BoatScriptedMovement>().isLeftOccupied = true;
                    transform.parent = boat.transform;
                    transform.localPosition = new Vector3(-277.8f, -300, 0);
                    Vector3 localRot = new Vector3(0, 90, 0);
                    transform.localRotation = Quaternion.Euler(localRot);
                }
                break;
            case "Back":
                {
                    boat.GetComponent<BoatScriptedMovement>().isBackOccupied = true;
                    transform.parent = boat.transform;
                    transform.localPosition = new Vector3(0, -300, -490);
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

                    anim.SetBool("isBoarding", isBoarding);
                }
                break;
        }
	}
    
    public void TriggerBoarding()
    {
        transform.localPosition += new Vector3(0, 200, 0);
        anim.SetTrigger("Board");
    }

    public void TriggerAttack()
    {
        isBoarding = false;
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

    public void OnCollisionEnterChild(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Player":
                break;
        }
    }
}
