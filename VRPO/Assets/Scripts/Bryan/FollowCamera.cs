using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour {
    public GameObject eyeCamera;
    public float y_Offset;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        StartCoroutine(FollowCam());
	}

    IEnumerator FollowCam()
    {
        yield return new WaitForEndOfFrame();

        transform.position = eyeCamera.transform.position;
        transform.position += new Vector3(0, y_Offset, 0);

        Quaternion newRotation = Quaternion.Euler(new Vector3(0, eyeCamera.transform.rotation.eulerAngles.y, eyeCamera.transform.rotation.eulerAngles.z));
        transform.rotation = newRotation;
    }
}
