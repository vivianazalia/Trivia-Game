using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Trivia.PackDataItem
{
    [System.Serializable]
    //[CreateAssetMenu(fileName ="LevelPack", menuName ="ScriptableObject/LevelPack", order = 1)]
    public class PackDataItem : ScriptableObject
    {
        public string PackID;
        public string PackName;
        public bool IsCompleted;
        public bool IsUnlocked;
        public int UnlockCost;

        public PackDataItem(string id, string name, bool isComplete, bool isUnlock, int cost)
        {
            PackID = id;
            PackName = name;
            IsCompleted = isComplete;
            IsUnlocked = isUnlock;
            UnlockCost = cost;
        }
    }

}
