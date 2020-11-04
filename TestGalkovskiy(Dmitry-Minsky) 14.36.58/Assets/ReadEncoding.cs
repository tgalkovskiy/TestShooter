using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class INFO
{
    public float speed;
    public float health;
    public string name;
    public string base64Texture;
    public Texture2D texture;

    public void Convert()
    {
        var BS64 = base64Texture;
        var BT = System.Convert.FromBase64String(BS64);
        var Texture2D = new Texture2D(2,2);
        texture = Texture2D;
    }
}
public class ReadEncoding : MonoBehaviour
{
    private INFO info;

    public INFO INFOPLYER => info;

    private void Awake()
    {
        var FilePlyer = File.ReadAllText("Assets/Unzip/" + "settings.json");
        var InfoFoPlyer = JsonUtility.FromJson<INFO>(FilePlyer);
        InfoFoPlyer.Convert();
        info = InfoFoPlyer;
    }
}
