using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera fpsCamera;
    [SerializeField] RigidbodyFirstPersonController fpsController;
    [SerializeField] float zoomInFOV = 20f;
    [SerializeField] float zoomOutFOV = 60f;
    [SerializeField] float zoonInSensitivity = 0.5f;
    [SerializeField] float zoomOutSensitivity = 2f;

    bool zoomOn = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (zoomOn)
            {
                zoomOn = false;
                fpsController.mouseLook.XSensitivity = zoomOutSensitivity;
                fpsController.mouseLook.XSensitivity = zoomOutSensitivity;
                fpsCamera.fieldOfView = zoomOutFOV;
            }
            else if(!zoomOn)
            {
                zoomOn = true;
                fpsController.mouseLook.XSensitivity = zoonInSensitivity;
                fpsController.mouseLook.XSensitivity = zoonInSensitivity;
                fpsCamera.fieldOfView = zoomInFOV; 
            }
            
        }
    }
}
