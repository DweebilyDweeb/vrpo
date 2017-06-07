using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleEffects : MonoBehaviour {
    public float lifetime;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (lifetime > 0)
            lifetime -= Time.deltaTime;
        else
            Destroy(gameObject);
	}
}
