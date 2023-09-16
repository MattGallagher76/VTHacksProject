using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.XR;

public class Recenter : MonoBehaviour
{

    private InputDevice targetDevice;
    public GameObject tempCube;

    // Start is called before the first frame update
    void Start()
    {
        List<InputDevice> devices = new List<InputDevice>();
        InputDeviceCharacteristics RightControllerChar = InputDeviceCharacteristics.Right | InputDeviceCharacteristics.Controller;
        InputDevices.GetDevicesWithCharacteristics(RightControllerChar, devices);

        if (devices.Count > 0)
            targetDevice = devices[0];
    }

    // Update is called once per frame
    void Update()
    {
        targetDevice.TryGetFeatureValue(CommonUsages.secondaryButton, out bool secondaryButtonValue);
        if (secondaryButtonValue)
            tempCube.transform.localPosition += new Vector3(0, 0.1f, 0);
    }

    void recenterHeadset()
    {
        transform.localPosition = Vector3.zero;
    }
}
