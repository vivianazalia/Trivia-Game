using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Trivia.Home
{
	public class HomeView : BaseSceneView
	{
		[SerializeField] private Button playButton;

		public void SetCallbacks(UnityAction onClickPlayButton)
		{
			playButton.onClick.RemoveAllListeners();
			playButton.onClick.AddListener(onClickPlayButton);
		}
	}
}