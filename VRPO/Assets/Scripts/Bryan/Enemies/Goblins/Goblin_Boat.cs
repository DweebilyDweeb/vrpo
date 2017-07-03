using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin_Boat : MonoBehaviour 
{
    float boatMovementSpeed;
    float boatRotateSpeed;
    float decelerateTimer = 3.0f;

    bool IsLeftTurn;
    bool IsRightTurn;
    bool IsRotationAccelerate;
    bool IsRotationDecelerate;
    bool paddlerDead;
    // Use this for initialization
    void Start()
    {
        boatMovementSpeed = 5;
        boatRotateSpeed = 0;
        IsLeftTurn = false;
        IsRightTurn = false;
        IsRotationAccelerate = false;
        IsRotationDecelerate = false;
        paddlerDead = false;
    }

    // Update is called once per frame
    void Update()
    {
        MovementOfBoat();
        RotationOfBoat();

        if (paddlerDead)
        {
            if (decelerateTimer > 0)
            {
                decelerateTimer -= Time.deltaTime;
                boatMovementSpeed -= ((boatMovementSpeed - 1.5f )/ decelerateTimer) * Time.deltaTime;
            }
        }
    }

    void MovementOfBoat()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * boatMovementSpeed, Space.Self);
    }

    void RotationOfBoat()
    {
        if (IsLeftTurn == true)
        {
            transform.Rotate(-Vector3.up * Time.deltaTime * boatRotateSpeed, Space.Self);
        }
        if (IsRightTurn == true)
        {
            transform.Rotate(Vector3.up * Time.deltaTime * boatRotateSpeed, Space.Self);
        }
        if (IsRotationDecelerate == true)
        {
            DecelerationOfRotation();
        }
        if (IsRotationAccelerate == true)
        {
            AccelerationOfRotation();
        }
    }

    void AccelerationOfRotation()
    {
        if (boatRotateSpeed < 15)
        {
            boatRotateSpeed += Time.deltaTime * 3;
        }

    }

    void DecelerationOfRotation()
    {
        if (boatRotateSpeed > 0)
        {
            boatRotateSpeed -= Time.deltaTime * 5;
        }
    }

    public void DecelerateToStop()
    {
        paddlerDead = true;
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "LeftTurn")
        {
            IsLeftTurn = true;
            IsRotationAccelerate = true;
            IsRotationDecelerate = false;
        }
        if (col.gameObject.name == "RightTurn")
        {
            IsRightTurn = true;
            IsRotationAccelerate = true;
            IsRotationDecelerate = false;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.name == "LeftTurn")
        {
            IsLeftTurn = false;
            IsRotationDecelerate = true;
            IsRotationAccelerate = false;
        }
        if (col.gameObject.name == "RightTurn")
        {
            IsRightTurn = false;
            IsRotationDecelerate = true;
            IsRotationAccelerate = false;
        }
    }

    public IEnumerator DespawnGoblin()
    {
        yield return new WaitForSeconds(1.0f);
        Destroy(transform.Find("Goblin").gameObject);
        Destroy(transform.Find("Weapon_L").gameObject);
        Destroy(transform.Find("Weapon_R").gameObject);
        Destroy(transform.Find("Paddle_001").gameObject);
    }
}
