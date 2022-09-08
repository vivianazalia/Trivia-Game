using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Trivia.PackData
{
    [System.Serializable]
    [CreateAssetMenu(fileName ="LevelPack", menuName ="ScriptableObject/LevelPack", order = 1)]
    public class PackData : ScriptableObject
    {
        public string PackID;
        public string PackName;
        public bool IsCompleted;
        public bool IsUnlocked;
        public int UnlockCost;

        // PackData(string id, string name, bool isComplete, bool isUnlock, int cost)
        //
        //ckID = id;
        //ckName = name;
        //Completed = isComplete;
        //Unlocked = isUnlock;
        //lockCost = cost;
        //
    }

}
