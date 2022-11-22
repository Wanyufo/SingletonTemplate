using System;
using System.Collections.Generic;
using IXRE.Scripts.Singleton;
using UnityEditor;
using UnityEngine;

namespace IXRE.Scripts.Tags
{
    
    /// <summary>
    /// This Tag Script is not meant for use, but rather as copy-paste source for new Tag Groups
    /// This Script type is also called a Tagger.
    /// For Instructions on how to add new Tags or TagGroups, please see the TagInstructions.txt
    /// </summary>
    public class GenericTag : MonoBehaviour, ITag
    {
        //
        // // ReSharper disable once InconsistentNaming
        // [SerializeField] public TagManager.GenericTag SmartTag;
        //
        // private void OnEnable()
        // {
        //     GM.I.tagManager.Tags[TagManager.TagTypes.GenericTag].Add(this);
        // }
        //
        // private void OnDestroy()
        // {
        //     GM.I.tagManager.Tags[TagManager.TagTypes.GenericTag].Remove(this);
        // }
    }
}