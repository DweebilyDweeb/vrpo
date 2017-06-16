using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleEffects : MonoBehaviour {
    public float lifetime;
    private Transform targetPosition, targetRotation;
    private Vector3 posOffset = new Vector3(0, 0, 0);
	// Use this for initialization
	void Start () {
		
	}

    public void Init(Transform parentPosition, Transform parentRotation)
    {
        targetPosition = parentPosition;
        targetRotation = parentRotation;

        transform.position = targetPosition.position + posOffset;
        transform.rotation = targetRotation.rotation;
    }

    public void Init(Transform parentPosition, Transform parentRotation, Vector3 positionOffset)
    {
        targetPosition = parentPosition;
        targetRotation = parentRotation;
        posOffset = positionOffset;

        transform.position = targetPosition.position + posOffset;
        transform.rotation = targetRotation.rotation;
    }
	
	// Update is called once per frame
	void Update () 
    {
        transform.position = targetPosition.position + posOffset;

        if (lifetime > 0)
            lifetime -= Time.deltaTime;
        else
            Destroy(gameObject);
	}

    private void OnDisable()
    {
        Destroy(gameObject);
    }
}
