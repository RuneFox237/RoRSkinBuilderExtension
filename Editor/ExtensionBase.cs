using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RuneFoxMods.RoRSkinBuilderExtension
{

  public class ExtensionBase : MonoBehaviour
  {
    private readonly string _name = "Base";
    public virtual string Name { get { return _name; } }
    

  }

}