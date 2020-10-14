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
    private float mouseSensitivity = 100f;
    private float Xrot;
    
    private void Update()
    {
        var MouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        Player.Rotate(0, 1 * MouseX, 0);
        var MouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        Body.Rotate(MouseY,0,0);
        //Xrot = -MouseY;
        //Xrot = Mathf.Clamp(Xrot, -60f, 60f);
        //Head.localRotation = Quaternion.Euler(Xrot, 0, 0);
        //.Rotate(Vector3.up * MouseX);

    }
}

