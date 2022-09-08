using Agate.MVC.Base;
using Agate.MVC.Core;
using System.Collections;
using System.Collections.Generic;
using Trivia.Boot;
using UnityEngine;

namespace Trivia.Level
{
    public class LevelLauncher : SceneLauncher<LevelLauncher, LevelView>
    {
        public override string SceneName => "Level";

        protected override IConnector[] GetSceneConnectors()
        {
            return null;
        }

        protected override IController[] GetSceneDependencies()
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
            SceneLoader.Instance.LoadScene("Pack");
        }

        public void SelectLevel(string levelID)
        {

        }
    }
}

