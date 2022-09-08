using Agate.MVC.Base;
using Agate.MVC.Core;
using System.Collections;
using System.Collections.Generic;
using Trivia.Boot;
using UnityEngine;

namespace Trivia.Pack
{
    public class PackLauncher : SceneLauncher<PackLauncher, PackView>
    {
        public override string SceneName => "Pack";

        protected override ILoad GetLoader()
        {
            return null;
        }

        protected override IMain GetMain()
        {
            return null;
        }

        protected override IConnector[] GetSceneConnectors()
        {
            return null;
        }

        protected override IController[] GetSceneDependencies()
        {
            return null;
        }

        protected override ISplash GetSplash()
        {
            return null;
        }

        protected override IEnumerator InitSceneObject()
        {
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

        }
    }

}
