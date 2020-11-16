using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefoltColor : MonoBehaviour
{
    
    private Color DefualtColor;
    private void Start()
    {
        DefualtColor = this.GetComponent<MeshRenderer>().material.color;

    }

    public void Defolt()
    {
        this.GetComponent<MeshRenderer>().material.color = DefualtColor;
    }
    
}
