using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin_Swimmer : Goblin 
{
    public bool isRightSide;
    private float speed, distFromBoat;
    private GameObject boat, boarderToSpawn;
	// Use this for initialization
	void Start () 
    {
        currentState = Goblin_FSM.Swim;
        anim = GetComponent<Animator>();
        boat = GameObject.FindGameObjectWithTag("Boat");
	}

    public void Init(bool isRight, float swimSpeed)
    {
        isRightSide = isRight;
        speed = swimSpeed;
    }
	
	// Update is called once per frame
	void Update () 
    {
		switch(currentState)
        {
            case Goblin_FSM.Swim:
                distFromBoat = new Vector3(boat.transform.position.x - transform.position.x, 0, boat.transform.position.z - transform.position.z).magnitude;
                if (distFromBoat < (speed * 4.5f))
                    currentState = Goblin_FSM.Dive;
                else
                    transform.position += transform.forward * Time.deltaTime * speed;

                transform.LookAt(boat.transform);
                break;
            case Goblin_FSM.Dive:
                transform.LookAt(boat.transform);
                transform.position += transform.forward * Time.deltaTime * speed;

                if (CheckBoatSides() != "Full")
                    anim.SetTrigger("Dive");
                else
                    currentState = Goblin_FSM.Swim;
                break;
            case Goblin_FSM.Board:
                transform.position = new Vector3(0, -100, 0);
                break;
            case Goblin_FSM.Death:
                if (!isDead)
                {
                    isDead = true;

                    anim.SetTrigger("Death");
                }
                break;
        }
	}

    private string CheckBoatSides()
    {
        if (isRightSide) // Check right first
        {
            if (!boat.GetComponent<BoatScriptedMovement>().isRightOccupied)
                return "Right";
            else if (!boat.GetComponent<BoatScriptedMovement>().isLeftOccupied)
                return "Left";
            else if (!boat.GetComponent<BoatScriptedMovement>().isBackOccupied)
                return "Back";
            else
                return "Full";
        }
        else // Check left first
        {
            if (!boat.GetComponent<BoatScriptedMovement>().isLeftOccupied)
                return "Left";
            else if (!boat.GetComponent<BoatScriptedMovement>().isRightOccupied)
                return "Right";
            else if (!boat.GetComponent<BoatScriptedMovement>().isBackOccupied)
                return "Back";
            else
                return "Full";
        }
    }

    private void ReserveBoatSide()
    {
        boarderToSpawn = Instantiate(Resources.Load<GameObject>("Prefabs/Enemies/Goblin_Boarder"));
        string side = CheckBoatSides();
        boarderToSpawn.GetComponent<Goblin_Boarder>().Init(side);
        boarderToSpawn.GetComponent<Goblin_Boarder>().SpawnBoarder(side);
    }

    private IEnumerator BoardShip()
    {
        currentState = Goblin_FSM.Board;

        yield return new WaitForSeconds(0.75f);

        boarderToSpawn.GetComponent<Goblin_Boarder>().TriggerBoarding();

        Destroy(gameObject); // Kill swimmers after spawning boarders
    }

    private void CheckBoatMidDive()
    {
        if (CheckBoatSides() == "Full")
        {
            anim.SetTrigger("Cancel_Dive");
            currentState = Goblin_FSM.Swim;
        }
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
