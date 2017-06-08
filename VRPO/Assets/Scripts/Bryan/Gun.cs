using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour 
{
    private ViveController controller = new ViveController();
    private float gunChargeTimer = 2.0f;
    private bool gunCharged = false;
	// Use this for initialization
	void Start () 
    {
        controller.Init();
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (controller.device.GetPressDown(controller.triggerButton))
        {
            if (gunChargeTimer > 0)
                gunChargeTimer -= Time.deltaTime;
            else
                gunCharged = true;
        }
        else
        {
            if (gunChargeTimer < 2 && !gunCharged)
                gunChargeTimer += Time.deltaTime;
        }
        if(controller.device.GetPressUp(controller.triggerButton) && gunCharged)
        {
            Fire();
            gunChargeTimer = 2.0f;
            gunCharged = false;
        }
	}

    private void Fire()
    {
        Debug.Log("Fired");
        int layerMask = 1 << 8;
        RaycastHit _hit;
        if (Physics.Raycast(transform.position, transform.forward * 10, out _hit, 10.0f, layerMask))
        {
            GameObject collide = _hit.collider.gameObject;
            switch(collide.tag)
            {
                case "Cannonball":
                    Destroy(collide);
                    break;
            }
        }
    }
}