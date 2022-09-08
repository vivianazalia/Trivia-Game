using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;

namespace Trivia.SaveData
{
    public class SaveDataModel : BaseModel
    {
        public int Coin;
        public string[] UnlockedPack;
        public string[] CompletedPack;
        public string[] CompletedLevel;
    }
}
