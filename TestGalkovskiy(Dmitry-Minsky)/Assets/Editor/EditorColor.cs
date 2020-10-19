using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(DefoltColor))]
public class EditorColor : Editor
{
    public override void OnInspectorGUI()
    {
        DefoltColor ColorD = new DefoltColor();
        if (GUILayout.Button("Defolt Color"))
        {
            ColorD.DefoltColorWall();
        }
        DrawDefaultInspector();
    }
}
