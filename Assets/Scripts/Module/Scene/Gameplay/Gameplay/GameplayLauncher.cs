using Agate.MVC.Base;
using Agate.MVC.Core;
using System.Collections;
using System.Collections.Generic;
using Trivia.Boot;
using UnityEngine;

namespace Trivia.Gameplay
{
    public class GameplayLauncher : SceneLauncher<GameplayLauncher, GameplayView>
    {
        public override string SceneName => "Gameplay";

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
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }

        public void QuitGame()
        {

        }

        public void GoToLevelScene()
        {

        }

        public void GoToPackScene()
        {

        }
    }
}
