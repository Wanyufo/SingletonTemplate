using System;
using System.Collections.Generic;
using IXRE.Scripts.Managers;
using IXRE.Scripts.Tags;
using UnityEngine;

namespace IXRE.Scripts.Singleton
{
    public class GM : MonoBehaviour
    {
        public TagManager tagManager;


        /// <summary>
        /// Local Awake Function, Same as MonoBehaviour Awake, but is only called on the unique Singleton
        /// </summary>
        private void GmAwake()
        {
        }


        /// <summary>
        /// Find all Managers and fill the Manager references
        /// Needs to be Updated Manually when new Manager Types are added
        /// </summary>
        private void GatherManagers()
        {
            tagManager = FindObjectOfType<TagManager>();
        }

        //############## SINGLETON INITIALISATION ###################
        public static GM I { get; private set; }

        private void Awake()
        {
            if (I == null)
            {
                I = this;
                GatherManagers();
                GmAwake();
            }
            else
            {
                Destroy(this);
                Debug.LogError("A second GM existed, has been destroyed");
                return;
            }
        }
    }
}