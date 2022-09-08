using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;

namespace Trivia.PackDataItem
{
    [System.Serializable]
    public class PackDataItemModel : BaseModel, IPackDataItemModel
    {
        public string PackID { get; private set; }
        public string PackName { get; private set; }
        public bool IsCompleted { get; private set; }
        public bool IsUnlocked { get; private set; }
        public int UnlockCost { get; private set; }

        public PackDataItemModel(string id, string name, bool isComplete, bool isUnlock, int cost) : this()
        {
            PackID = id;
            PackName = name;
            IsCompleted = isComplete;
            IsUnlocked = isUnlock;
            UnlockCost = cost;
        }

        public PackDataItemModel()
        {
            PackID = "A";
            PackName = "Pack A";
            IsCompleted = false;
            IsUnlocked = false;
            UnlockCost = 100;
        }
    }

}
