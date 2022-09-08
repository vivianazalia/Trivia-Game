using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Trivia.Level
{
    public class LevelView : BaseSceneView
    {
        [SerializeField] private Button backButton;

        public void SetCallbacks(UnityAction onClickBackButton)
        {
            backButton.onClick.RemoveAllListeners();
            backButton.onClick.AddListener(onClickBackButton);
        }
    }

}
