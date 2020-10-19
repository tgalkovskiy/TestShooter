using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(DefoltColor))]
public class EditorColor : Editor
{
    
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        DefoltColor defolt = target as DefoltColor;
        if (GUILayout.Button("Defolt Color"))
        {
            defolt.Defolt();
            //defolt.GetComponent<Renderer>().sharedMaterial.color = Color.cyan;
            //defolt.GetComponent<MeshRenderer>().material.color = defolt.Defolt();
        }
        
    }
}
