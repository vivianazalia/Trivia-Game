using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;

namespace Trivia.PackDataItem
{
    public interface IPackDataItemModel : IBaseModel
    {
        public string PackID { get; }
        public string PackName { get; }
        public bool IsCompleted { get; }
        public bool IsUnlocked { get; }
        public int UnlockCost { get; }
    }

}
