using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO.Compression;
using  System.IO;
using System.Security.Policy;
using UnityEngine.Networking;

public class Encoding : MonoBehaviour
{
   private  static string PathDowland = "https://dminsky.com/settings.zip";
   private static string PathSaveZip = Path.Combine(Application.persistentDataPath, "settings.zip");
   [MenuItem("Tools/DowlandSetting")]
   public static void DowlandSetting()
   {
      Debug.Log(Path.Combine(Application.persistentDataPath, "settings.zip"));
      UnityWebRequest UWR = UnityWebRequest.Get(PathDowland);
      UWR.downloadHandler = new DownloadHandlerFile(PathSaveZip);
      var aspp = UWR.SendWebRequest();
      if (UWR.isHttpError || UWR.isNetworkError)
      {
         Debug.Log("Error");
      }
      else
      {
         Debug.Log("Completed");
         ZipFile.ExtractToDirectory(PathSaveZip, "Assets/UnZip/");
         var FileConvert = File.ReadAllText("Assets/Unzip/" + "settings.json");
         var InfoPlyer = JsonUtility.FromJson<INFO>(FileConvert);
      }
   }
   
}
