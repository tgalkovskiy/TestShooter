using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    [SerializeField] 
    private Transform Body;
    [SerializeField] 
    private Transform Player;
    [SerializeField] 
    private Camera CameraPlayer;
    [SerializeField]
    private float mouseSensitivity;
    [SerializeField]
    private float YAxisAngleLock = 90f;
    private Vector2 Rotation;
    private Quaternion PlayerTargetRot;
    private Quaternion CameraTargetRot;
    
    private void Start()
    {
        Player = transform;
        PlayerTargetRot = Player.rotation;
        CameraTargetRot = CameraPlayer.transform.rotation;
    }

    private void RotCam()
    {
        var MouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        Player.Rotate(0, 1 * MouseX, 0);
        var MouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        Body.Rotate(MouseY,0,0);
    }

    private void ZoomCamera()
    {
        if (Input.GetMouseButton(0))
        {
            
            CameraPlayer.fieldOfView = Mathf.Lerp(CameraPlayer.fieldOfView,30, Time.deltaTime*10);
        }
        else
        {
            CameraPlayer.fieldOfView = Mathf.Lerp(CameraPlayer.fieldOfView, 60, Time.deltaTime*10);
        }
        
    }
    private void Update()
    {
        RotCam();
        ZoomCamera();
    }
}

