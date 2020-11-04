using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] private float Speed, Sens;
    [SerializeField] private GameObject OBJTest;
    private string Name;
    private int Health;
    private Vector3 Velocity;
    private ReadEncoding ReadEncoding;
    public GameObject Player2;
    [SerializeField]
    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Speed = ReadEncoding.INFOPLYER.speed;
        Name = ReadEncoding.INFOPLYER.name;
        OBJTest.GetComponent<MeshRenderer>().material.SetTexture("_BumMap",ReadEncoding.INFOPLYER.texture);
        OBJTest.GetComponent<MeshRenderer>().material.EnableKeyword("_NORMALMAP");
    }

    void Start()
    {
        
    }
    private void MovmentPlayerOne()
    {
        Velocity = new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));
        if (Input.GetKey(KeyCode.W)||Input.GetKey(KeyCode.S)||Input.GetKey(KeyCode.A)||Input.GetKey(KeyCode.D))
        {
            transform.Translate(Velocity*Speed*Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.I)||Input.GetKey(KeyCode.K)||Input.GetKey(KeyCode.J)||Input.GetKey(KeyCode.L))
        {
            Player2.transform.Translate(Velocity*Speed*Time.deltaTime);
        }
    }
    // Update is called once per frame
    void Update()
    {
        MovmentPlayerOne();
    }
}
