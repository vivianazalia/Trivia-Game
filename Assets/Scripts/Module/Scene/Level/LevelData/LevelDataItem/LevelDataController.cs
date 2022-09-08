using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;

namespace Trivia.LevelData
{
    public class LevelDataController : ObjectController<LevelDataController, LevelDataModel, ILevelDataModel, LevelDataView>
    {
        private const string levelIDSelected = "levelID";
        public void Init(LevelDataModel model, LevelDataView view)
        {
            _model = model;
            SetView(view);
        }

        public void OnSelectButton()
        {
            PlayerPrefs.SetString(levelIDSelected, _model.LevelID);
            Debug.Log("Select level " + _model.LevelName);
        }

        public override void SetView(LevelDataView view)
        {
            base.SetView(view);
            _view.SetButtonListener(OnSelectButton);
        }
    }

}
