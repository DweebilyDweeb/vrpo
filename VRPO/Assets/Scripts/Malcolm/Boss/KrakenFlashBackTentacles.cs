using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KrakenFlashBackTentacles : MonoBehaviour {
    private KeyCode Attack;
    Animator anim;

    private GameObject cameraRig;
	// Use this for initialization
	void Start ()
    {
        Attack = KeyCode.Keypad5;
        anim = GetComponent<Animator>();

        cameraRig = GameObject.FindGameObjectWithTag("MainCamera");
    }
	
	// Update is called once per frame
	void Update ()
    {
        RunAnimation();
	}

    void RunAnimation()
    {
        if (Input.GetKey(Attack))
        {
            anim.SetTrigger("Attack");
        }
    }

    void TriggerBlackout()
    {
        cameraRig.GetComponent<UnityEngine.PostProcessing.Utilities.PostProcessingController>().testchange1 = false;
        StartCoroutine(sceneChange(5.0f));
    }

    IEnumerator sceneChange(float delay)
    {
        yield return new WaitForSeconds(delay);

        SceneManager.LoadScene("demoScene 6");
    }
}
