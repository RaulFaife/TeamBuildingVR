using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.SceneManagement;

public class ReturnHome : MonoBehaviour
{
    private InputDevice targetDevice;

    // Start is called before the first frame update
    void Start()
    {


    }


    // Update is called once per frame
    void Update()
    {
        List<InputDevice> devices = new List<InputDevice>();

        InputDeviceCharacteristics rightControllerCharacteristics = InputDeviceCharacteristics.Right | InputDeviceCharacteristics.Controller;
        InputDevices.GetDevicesWithCharacteristics(rightControllerCharacteristics, devices);

        if(devices.Count > 0){
            targetDevice = devices[0];
        }
        
        targetDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool primaryButtonValue);
        if(primaryButtonValue){
            //Debug.Log("Returning Home");
            SceneManager.LoadScene("Main_Scene");
        }
    }


}
