using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OtherSettings : MonoBehaviour 
{
	//Fool's day https://clck.ru/9TFat
	public void SocialNetworks ()
	{
		Application.OpenURL ("https://vk.com/s_topgames");
	}
	[SerializeField]
	private GameObject quitPanel;
	public void FakeChoice ()
	{
		quitPanel.SetActive (true);
	}
	public void BestPage ()
	{
		Application.OpenURL ("https://github.com/VitalikLevin/Nature-vs.-Evil-Sprits/wiki");
	}
}
