using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;

namespace Trivia.PackData
{
    public class PackDataController : ObjectController<PackDataController, PackDataModel, PackDataView>
    {
        private List<PackDataModel> packData = new List<PackDataModel>();

        public void LoadPackList()
        {

        }

        public List<PackDataModel> GetPackList()
        {
            return packData;
        }

        public void InitPackList(List<PackDataModel> pack)
        {
            packData = pack;
        }

        public void OnSelectButton()
        {
            Debug.Log("Select Pack");
        }

        public void OnUnlockButton()
        {
            Debug.Log("Unlock Pack");
        }

        public override void SetView(PackDataView view)
        {
            base.SetView(view);
            _view.SetButtonListener(OnSelectButton, OnUnlockButton);
        }
    }

}
