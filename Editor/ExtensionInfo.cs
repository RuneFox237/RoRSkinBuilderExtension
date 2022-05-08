using UnityEngine;
using RoRSkinBuilder.Data;
using System.Collections.Generic;

namespace RuneFoxMods.RoRSkinBuilderExtension
{

  [AddComponentMenu("RoR Skins/Skin Builder Extension")]
  public class ExtensionInfo : MonoBehaviour
  {
    public SkinModInfo modInfo;
    public AssetsInfo assetInfo;

    public List<ExtensionBase> extensions = new List<ExtensionBase>();

    public ExtensionInfo(ExtensionInfo info)
    {
      modInfo = info.modInfo;
      InitializeAssetInfo();
    }
    public void InitializeAssetInfo()
    {
      assetInfo = new AssetsInfo(modInfo);
    }

  }

}