using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;

namespace Trivia.PackDataItem
{
    public class PackDataItemController : ObjectController<PackDataItemController, PackDataItemModel, IPackDataItemModel, PackDataItemView>
    {
        private const string packIDSelected = "packID";

        public void Init(PackDataItemModel model, PackDataItemView view)
        {
            _model = model;
            SetView(view);
        }

        public void OnSelectButton()
        {
            PlayerPrefs.SetString(packIDSelected, _model.PackID);
        }

        public void OnUnlockButton()
        {
            Debug.Log("Unlock Pack " + _model.IsUnlocked);
        }
        public override void SetView(PackDataItemView view)
        {
            base.SetView(view);
            _view.SetButtonListener(OnSelectButton, OnUnlockButton);
        }
    }

}
