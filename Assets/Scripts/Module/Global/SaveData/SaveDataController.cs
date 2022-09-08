using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Trivia.Database;

namespace Trivia.SaveData
{
    public class SaveDataController : DataController<SaveDataController, SaveDataModel>
    {
        private const string key = "gameData";

        private LevelStruct[] levelList = new LevelStruct[20];

        //Testing save and load data
        //Set init data
        public void Save()
        {
            var data = levelList;
            PlayerPrefs.SetString(key, data.ToString());
        }

        public void Load()
        {
            if (!PlayerPrefs.HasKey(key))
            {
                for(int i = 0; i < 5; i++)
                {
                    for(int j = 0; j < 4; j++)
                    {
                        levelList[i*j] = AddLevel(i.ToString(), j.ToString(), "", "", null, 0);
                    }
                }

                Save();
            }
            else
            {
                var loadData = PlayerPrefs.GetString(key);
            }
        }

        private LevelStruct AddLevel(string id, string packId, string question, string hint, List<string> choices, int answer)
        {
            return new LevelStruct(id, packId, question, hint, choices, answer);
        }
    }

}
