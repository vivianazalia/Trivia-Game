using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;

namespace Trivia.LevelData
{
    [System.Serializable]
    public class LevelDataModel : BaseModel, ILevelDataModel
    {
        public string LevelID { get; private set; }
        public string LevelName { get; private set; }
        public bool IsCompleted { get; private set; }

        public LevelDataModel(string id, string name, bool isComplete) : this()
        {
            LevelID = id;
            LevelName = name;
            IsCompleted = isComplete;
        }

        public LevelDataModel()
        {
            LevelID = "A";
            LevelName = "Level-A";
            IsCompleted = false;
        }
    }
}
