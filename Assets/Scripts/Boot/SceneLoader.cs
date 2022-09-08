using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;


namespace Trivia.Boot
{
    public class SceneLoader : BaseLoader<SceneLoader>
    {
        protected override string SplashScene => "SplashScreen";
    }
}