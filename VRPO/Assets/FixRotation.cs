using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixRotation : MonoBehaviour {

    Vector3 rotation, rotationDiff;
    Transform camEye;
    void Awake()
    {
        rotation = transform.eulerAngles;
        camEye = Camera.main.transform;
        rotationDiff = camEye.eulerAngles - rotation;
    }
    void LateUpdate()
    {
        StartCoroutine(FuckVR());
    }

    IEnumerator FuckVR()
    {
        yield return new WaitForEndOfFrame();

        Quaternion newRotation = new Quaternion();
        newRotation.eulerAngles = new Vector3(camEye.localEulerAngles.x - 90, camEye.localEulerAngles.y, camEye.localEulerAngles.z);
        //newRotation.eulerAngles = new Vector3(newRotation.eulerAngles.x + 180, newRotation.eulerAngles.y, newRotation.eulerAngles.z);

        transform.rotation = newRotation;
        Debug.Log("rotation: " + camEye.eulerAngles);
    }
}
