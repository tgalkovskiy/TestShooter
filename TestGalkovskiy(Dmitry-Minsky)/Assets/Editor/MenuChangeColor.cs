using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MenuChangeColor 
{
    [MenuItem("Tools/ColorAllChange")]
    private static void CollorAllRed()
    {
        GameObject[] AllObj = GameObject.FindObjectsOfType<GameObject>();
        foreach (var A in AllObj)
        {
            if (A.GetComponent<Renderer>())
            {
                A.GetComponent<Renderer>().material.color = Color.green;
                Debug.Log("All change Color");
            }
        }
        //for (int i = 0; i < AllObj.Length; i++)
        //{
           // if (AllObj[i].GetComponent<Renderer>())
            //{
               //AllObj[i].GetComponent<Renderer>().material.color=Color.green;
              // Debug.Log("All change Color"); 
            //}
    }
}
