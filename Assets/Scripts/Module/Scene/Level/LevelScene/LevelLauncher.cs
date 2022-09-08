using Agate.MVC.Base;
using Agate.MVC.Core;
using System.Collections;
using System.Collections.Generic;
using Trivia.Boot;
using UnityEngine;
using Trivia.LevelSpawner;

namespace Trivia.Level
{
    public class LevelLauncher : SceneLauncher<LevelLauncher, LevelView>
    {
        public override string SceneName => "Level";

        private LevelSpawnerController levelSpawnerController;

        protected override IConnector[] GetSceneConnectors()
        {
            return null;
        }

        protected override IController[] GetSceneDependencies()
        {
            return new IController[]
            {
                new LevelSpawnerController()
            };
        }

        protected override IEnumerator InitSceneObject()
        {
            _view.SetCallbacks(GoBack);
            levelSpawnerController.SetView(_view.levelSpawnerView);
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
            SceneLoader.Instance.LoadScene("Gameplay");
        }
    }
}

