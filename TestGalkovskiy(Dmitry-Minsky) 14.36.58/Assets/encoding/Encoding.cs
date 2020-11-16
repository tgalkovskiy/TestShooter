using System;
using System.Text;
using UnityEditor;
using UnityEngine;
using System.IO.Compression;
using System.IO;
using UnityEngine.Networking;

public class Settings
{
   public float Speed;
   public int Health;
   public string Name;
   public string Base64;
}

public class Encoding : MonoBehaviour
{
   private Settings PlyerSetting;
   private static string PathDowland = "https://dminsky.com/settings.zip";
   private static string PathSaveZip = Path.Combine("Assets/Unzip!", "settings.zip");
   private static string PathSaveFile = Path.Combine("Assets/Unzip!");
   private static string PathReadFile = Path.Combine("Assets/Unzip!", "settings.json");
   [MenuItem("Tools/DowlandSetting")]
   public static void DowlandSetting()
   {
      try
      {
         UnityWebRequest UWR = UnityWebRequest.Get(PathDowland);
         UWR.downloadHandler = new DownloadHandlerFile(PathSaveZip);
         var aspp = UWR.SendWebRequest();
      }
      catch (Exception e)
      {
         Debug.Log("Error NetWork");
      }
      finally
      {
         Debug.Log("Completed Dowland");
         AssetDatabase.Refresh();
      }
   }

   [MenuItem("Tools/UnZip")]
   public static void UnZip()
   {
      try
      {
         ZipFile.ExtractToDirectory(PathSaveZip, PathSaveFile);
         AssetDatabase.Refresh();
      }
      catch (Exception e)
      {
         Debug.Log("Error Extract");
      }
      finally
      {
         Debug.Log("Completed Extract");
         AssetDatabase.Refresh();
      }
         
   }

}

