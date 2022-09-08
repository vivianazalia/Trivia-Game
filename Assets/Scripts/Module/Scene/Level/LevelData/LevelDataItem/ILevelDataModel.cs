using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;

namespace Trivia.LevelData
{
    public interface ILevelDataModel : IBaseModel
    {
        public string LevelID { get; }
        public string LevelName { get; }
        public bool IsCompleted { get; }
    }

}
