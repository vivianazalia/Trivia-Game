using Agate.MVC.Base;
using Agate.MVC.Core;
using System.Collections;
using System.Collections.Generic;
using Trivia.Boot;
using UnityEngine;
using Trivia.PackData;

namespace Trivia.Pack
{
    public class PackLauncher : SceneLauncher<PackLauncher, PackView>
    {
        public override string SceneName => "Pack";

        private PackDataController packDataController;

        protected override IConnector[] GetSceneConnectors()
        {
            return null;
        }

        protected override IController[] GetSceneDependencies()
        {
            return new IController[]
            {
                new PackDataController()
            };
        }

        protected override IEnumerator InitSceneObject()
        {
            packDataController.SetView(_view.packDataView);
            _view.SetCallbacks(GoBack);
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }

        public void GoBack()
        {
            SceneLoader.Instance.LoadScene("Home");
        }

        public void SelectPack(string packID)
        {
            SceneLoader.Instance.LoadScene("Level");
        }
    }

}
