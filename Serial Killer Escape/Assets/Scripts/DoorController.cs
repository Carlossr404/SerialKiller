using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR;
//using Valve.VR;

public class DoorController : MonoBehaviour
{
    /*
    public Animation anim;

    [SerializeField]
    private XRNode xrNode = XRNode.RightHand;
    private List<InputDevice> devices = new List<InputDevice>();
    private InputDevice device;
    //private var gameControllers;

    private bool triggerButtonPressed = false;


    void GetDevice()
    {
        InputDevices.GetDevicesAtXRNode(xrNode, devices);
        device = devices.FirstOrDefault();
    }

    void OnEnable()
    {
        if (!device.isValid)
        {
            GetDevice();
        }

      //  anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Checks if device is valid
        if (!device.isValid)
        {
            GetDevice();
        }

        //Once we have device, obtain features
        List<InputFeatureUsage> features = new List<InputFeatureUsage>();
        device.TryGetFeatureUsages(features);

        bool triggerButtonValue;
        if(device.TryGetFeaturesValue(CommonUsages.triggerButton, out triggerButtonValue) && triggerButtonPressed && !triggerButtonPressed)
        {
            triggerButtonPressed = true;
            Debug.Log("Right trigger pressed");
        }
        else if (!triggerButtonValue && triggerButtonPressed)
        {
            triggerButtonPressed = false;
            Debug.Log("Right trigger released");
        }


    }

    void OnCollisionEnter(Collision collision)
    {
    }
    */

}
