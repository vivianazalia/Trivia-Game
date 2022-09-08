using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Trivia.PackDataItem;
using Trivia.LevelData;

namespace Trivia.LevelSpawner
{
    public class LevelSpawnerModel : BaseModel
    {
        public List<LevelDataModel> PackDataItem { get; private set; } = new();
        private const string key = "levelID";

        public void Load()
        {
            
        }

        public void AddPackDataItem()
        {

        }

        public void AddToList(LevelDataModel item)
        {
            PackDataItem.Add(item);
        }


    }

}
