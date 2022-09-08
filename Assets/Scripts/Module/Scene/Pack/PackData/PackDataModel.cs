using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Trivia.PackDataItem;

namespace Trivia.PackData
{
    public class PackDataModel : BaseModel
    {
        public List<PackDataItemModel> PackDataItem { get; private set; } = new();
        private const string file = "pack";

        public void Load()
        {
            
        }

        public void AddPackDataItem()
        {

        }

        public void AddToList(PackDataItemModel item)
        {
            PackDataItem.Add(item);
        }


    }

}
