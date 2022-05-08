using UnityEngine;
using UnityEditor;
using System.IO;


namespace RuneFoxMods.RoRSkinBuilderExtension
{
  [CustomEditor(typeof(ExtensionInfo))]
  public class ExtensionInfoPropertyDrawer : Editor
  {

    public override void OnInspectorGUI()
    {
      base.OnInspectorGUI();

      //var extensions = (serializedObject.targetObject as ExtensionInfo).transform.GetComponentsInChildren<ExtensionBase>();
      //(serializedObject.targetObject as ExtensionInfo).extension.Clear();
      //
      //foreach (var ext in extensions)
      //{
      //  (serializedObject.targetObject as ExtensionInfo).extension.Add(ext);
      //}

      if (GUILayout.Button("Build"))
      {
        Build(serializedObject.targetObject as ExtensionInfo);  
      }
    }


    //TODO: DaisyChain the DynamicSkins and CustomItemDisplay stuff on build
    private void Build(ExtensionInfo info)
    {
      if (info.assetInfo == null) info.InitializeAssetInfo();

      var path = Path.Combine(info.assetInfo.modFolder, info.modInfo.name + "Extension.cs");

      var ExtensionCode = new ExtensionTemplate(info);

      File.WriteAllText(path, ExtensionCode.TransformText());

      AssetDatabase.ImportAsset(path, ImportAssetOptions.ForceUpdate);
      
      Debug.Log("Skin Builder Extension Finished");
    }
  }
}
