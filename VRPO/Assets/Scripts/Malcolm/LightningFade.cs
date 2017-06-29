using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningFade : MonoBehaviour {
    // Use this for initialization
    void Start () {
        StartCoroutine(Wait(0.5f));
        Destroy(gameObject,10);
    }

    IEnumerator Wait(float seconds)
    {
        yield return new WaitForSeconds(seconds); //this will wait 5 seconds
        transform.GetChild(0).GetComponent<Renderer>().enabled = false;
    }

    // Update is called once per frame
    void Update () {

    }

}
