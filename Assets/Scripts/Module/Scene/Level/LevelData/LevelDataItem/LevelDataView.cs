using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using TMPro;
using UnityEngine.UI;
using UnityEngine.Events;

namespace Trivia.LevelData
{
    public class LevelDataView : ObjectView<ILevelDataModel>
    {
        [SerializeField] private TMP_Text levelNameLabel;
        [SerializeField] private Button selectButton;
        [SerializeField] private Image completeImage;

        protected override void InitRenderModel(ILevelDataModel model)
        {
            levelNameLabel.text = model.LevelName;
        }

        protected override void UpdateRenderModel(ILevelDataModel model)
        {
            levelNameLabel.text = model.LevelName;
        }

        public void SetButtonListener(UnityAction onSelectButton)
        {
            selectButton.onClick.RemoveAllListeners();
            selectButton.onClick.AddListener(onSelectButton);
        }
    }

}
