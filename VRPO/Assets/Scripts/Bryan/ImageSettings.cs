using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageSettings : MonoBehaviour 
{
    private Image thisImage;
	// Use this for initialization
	void Start () {
        thisImage = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () 
    {
        byte r = (byte)Random.Range(0, 255.0f);
        byte g = (byte)Random.Range(0, 255.0f);
        byte b = (byte)Random.Range(0, 255.0f);
        thisImage.color = new Color32(r, g, b, 255);
	}
}
