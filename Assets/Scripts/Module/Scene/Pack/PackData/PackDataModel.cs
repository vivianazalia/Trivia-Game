using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;

namespace Trivia.PackData
{
    public class PackDataModel : BaseModel
    {
        private List<PackData> packData = new List<PackData>();

        private const string key = "pack";

        public void Load()
        {

        }
    }

}
