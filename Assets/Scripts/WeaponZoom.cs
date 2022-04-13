using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera fpsCamera;
    [SerializeField] float zoomInFOV = 20f;
    [SerializeField] float zoomOutFOV = 60f;
    
    bool zoomOn = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (zoomOn)
            {
                zoomOn = false;
                fpsCamera.fieldOfView = zoomOutFOV;
            }
            else if(!zoomOn)
            {
                zoomOn = true;
                fpsCamera.fieldOfView = zoomInFOV; 
            }
            
        }
    }
}
