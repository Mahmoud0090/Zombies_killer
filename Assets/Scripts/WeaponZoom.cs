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

    private void OnDisable()
    {
        ZoomOut();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (zoomOn)
            {
                ZoomOut();
            }
            else if(!zoomOn)
            {
                ZoomIn();
            }
        }
    }

    private void ZoomOut()
    {
        zoomOn = false;
        fpsController.mouseLook.XSensitivity = zoomOutSensitivity;
        fpsController.mouseLook.XSensitivity = zoomOutSensitivity;
        fpsCamera.fieldOfView = zoomOutFOV;
    }
    private void ZoomIn()
    {
        zoomOn = true;
        fpsController.mouseLook.XSensitivity = zoonInSensitivity;
        fpsController.mouseLook.XSensitivity = zoonInSensitivity;
        fpsCamera.fieldOfView = zoomInFOV;
    }
    // this methode is redandant but we can call from WeaponSwitcher class instead of using OnDisable methode above
    public void ResetZoom()
    {
        ZoomOut();
    }
}
