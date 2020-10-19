using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorName : MonoBehaviour
{
    void Start()
    {
        Debug.Log(this.GetComponent<Renderer>().material.color);
    }

    
}
