using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using TMPro;
using UnityEngine.UI;
using UnityEngine.Events;

namespace Trivia.PackDataItem
{
    public class PackDataItemView : ObjectView<IPackDataItemModel>
    {
        [SerializeField] private TMP_Text packNameLabel;
        [SerializeField] private TMP_Text unlockCostLabel;
        [SerializeField] private Button selectButton;
        [SerializeField] private Button unlockButton;
        [SerializeField] private Image completeImage;

        public void SetButtonListener(UnityAction onSelectButton, UnityAction onUnlockButton)
        {
            selectButton.onClick.RemoveAllListeners();
            unlockButton.onClick.RemoveAllListeners();
            selectButton.onClick.AddListener(onSelectButton);
            unlockButton.onClick.AddListener(onUnlockButton);
        }

        protected override void InitRenderModel(IPackDataItemModel model)
        {
            packNameLabel.text = model.PackName;
            unlockCostLabel.text = model.UnlockCost.ToString();
        }

        protected override void UpdateRenderModel(IPackDataItemModel model)
        {
            packNameLabel.text = model.PackName;
            unlockCostLabel.text = model.UnlockCost.ToString();
        }
    }

}
