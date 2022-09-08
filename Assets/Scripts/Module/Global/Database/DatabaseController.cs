using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;

namespace Trivia.Database
{
    public class DatabaseController : BaseController<DatabaseController>
    {
        public List<string> GetPackList()
        {
            return null;
        }

        public List<string> GetLevelList(string packID)
        {
            return null;
        }

        public LevelStruct GetLevelData(string levelID)
        {
            return new LevelStruct();
        }
    }
}

