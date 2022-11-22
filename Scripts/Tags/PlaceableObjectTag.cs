using System;
using System.Collections.Generic;
using IXRE.Scripts.Managers;
using IXRE.Scripts.Singleton;
using UnityEditor;
using UnityEngine;

namespace IXRE.Scripts.Tags
{
    public class PlaceableObjectTag : MonoBehaviour, ITag
    {
        [SerializeField] public TagManager.PlaceableObjectTag smartTag;

        private void OnEnable()
        {
            GM.I.TagManager.RegisterTag(smartTag, this);
        }

        private void OnDestroy()
        {
            GM.I.TagManager.DeRegisterTag(smartTag, this);
        }

        public Enum GetTag()
        {
            return smartTag;
        }
    }
}