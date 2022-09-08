using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using Trivia.PackData;
using Trivia.PackDataItem;

namespace Trivia.Pack
{
    public class PackView : BaseSceneView
    {
        public Button backButton;

        public PackDataView packDataView;
        public PackDataItemView packDataItemView;

        public void SetCallbacks(UnityAction onClickBackButton)
        {
            backButton.onClick.RemoveAllListeners();
            backButton.onClick.AddListener(onClickBackButton);
        }
    }

}
