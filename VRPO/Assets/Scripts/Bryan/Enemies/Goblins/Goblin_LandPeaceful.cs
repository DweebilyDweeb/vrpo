using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin_LandPeaceful : Goblin
{
    public float detectionRange;
    private float distFromPlayer;
    private bool inRange, hasDetectedPlayer;
    private GameObject player;
    // Use this for initialization
    void Start()
    {
        hasDetectedPlayer = false;
        anim = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        switch(currentState)
        {
            case Goblin_FSM.Idle:
                #region check if player is in range
                distFromPlayer = new Vector3(player.transform.position.x - transform.position.x, 0, player.transform.position.z - transform.position.z).magnitude;

                if (distFromPlayer < detectionRange)
                {
                    inRange = true;
                    if (!hasDetectedPlayer)
                        hasDetectedPlayer = true;
                }
                else
                    inRange = false;
                #endregion
                break;
            case Goblin_FSM.Death:
                if (!isDead)
                {
                    isDead = true;

                    anim.SetTrigger("Death");
                    bool anim1 = HelperFunctions.RandomBool();
                    if (!hasDetectedPlayer) // Play unalarmed death animations
                    {
                        if (anim1)
                            anim.SetInteger("Death_Type", 1);
                        else
                            anim.SetInteger("Death_Type", 2);
                    }
                    else // Play alarmed death animations
                    {
                        if (anim1)
                            anim.SetInteger("Death_Type", 3);
                        else
                            anim.SetInteger("Death_Type", 4);
                    }
                }
                break;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Matrix4x4 rotationMatrix = Matrix4x4.TRS(transform.position, transform.rotation, transform.lossyScale);
        Gizmos.matrix = rotationMatrix;
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(Vector3.zero, (detectionRange / transform.localScale.x));
    }
}
