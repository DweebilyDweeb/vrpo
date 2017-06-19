using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViveController
{
    #region Buttons
    public Valve.VR.EVRButtonId triggerButton = Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger;
    public Valve.VR.EVRButtonId touchPad = Valve.VR.EVRButtonId.k_EButton_SteamVR_Touchpad;
    public Valve.VR.EVRButtonId menuButton = Valve.VR.EVRButtonId.k_EButton_ApplicationMenu;
    #endregion

    public SteamVR_TrackedObject trackedObject;
    public SteamVR_Controller.Device device;
		
	// Update is called once per frame
	public void Update () {
        device = SteamVR_Controller.Input((int)trackedObject.index);
	}
}
