using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rope : MonoBehaviour 
{
    public bool isCut = false;
    private Animator anim;
	// Use this for initialization
	void Start () 
    {
        anim = GetComponent<Animator>();
        TriggerCut();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TriggerCut()
    {
        StartCoroutine(Cut());
    }

    private IEnumerator Cut()
    {
        anim.SetTrigger("Cut");
        yield return new WaitForSeconds(0.5f);
        isCut = true;
        yield return new WaitForSeconds(1.0f);
        Destroy(gameObject);
    }
}
