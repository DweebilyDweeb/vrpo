using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin_Swimmer : Goblin 
{
    public bool isRightSide;
    private float speed, distFromBoat;
    private GameObject boat;
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

                transform.LookAt(boat.transform);
                transform.position += transform.forward * Time.deltaTime * speed;                
                break;
            case Goblin_FSM.Dive:
                transform.LookAt(boat.transform);
                transform.position += transform.forward * Time.deltaTime * speed;
                anim.SetTrigger("Dive");
                break;
            case Goblin_FSM.Death:
                anim.SetTrigger("Death");
                break;
        }
	}

    public void SpawnBoarders()
    {
        // instantiate boarder goblins and despawn swimmers
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
