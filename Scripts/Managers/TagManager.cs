using System;
using System.Collections.Generic;
using IXRE.Scripts.Singleton;
using UnityEngine;

namespace IXRE.Scripts.Managers
{
    public class TagManager : MonoBehaviour, IManager
    {
        /// <summary>
        /// Dictionary of all List for each TagType
        /// </summary>
        public Dictionary<TagGroups, List<ITag>> Tags { get; } = new Dictionary<TagGroups, List<ITag>>();


        // ##### Start of Tag Edit Area #####
        // For Instructions on how to add new Tags or TagGroups, please see the TagInstructions.txt


        /// <summary>
        /// Must Contain all the Names of TagGroups
        /// Must be Updated Manually
        /// </summary>
        public enum TagGroups
        {
            PlaceableObjectTag,
        }


        // ### Tag Group Enums ###
        public enum PlaceableObjectTags
        {
            Object1,
            Object2,
            Object3,
            Object4,
            Object5,
        }


        // ##### End of Tag Edit Area #####

        /// <summary>
        /// Adds a List to the Dictionary for each TagGroup in enum: TagGroups
        /// </summary>
        private void Awake()
        {
            string foundTagGroups = "";

            foreach (TagGroups tagType in Enum.GetValues(typeof(TagGroups)))
            {
                Tags[tagType] = new List<ITag>();
                foundTagGroups += tagType + "\n";
            }

            Debug.Log("Found the following TagGroups\n" + foundTagGroups);
        }
    }
}