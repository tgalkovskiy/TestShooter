using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefoltColor : MonoBehaviour
{
    [SerializeField]
    private GameObject Wall;
    
    public void DefoltColorWall()
    {
        Wall.GetComponent<Renderer>().material.color = Color.magenta;
    }
    
}
