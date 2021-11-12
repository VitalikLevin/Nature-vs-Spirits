using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OtherSettings : MonoBehaviour 
{
	//https://github.com/VitalikLevin/Bounce-s-Adventure
	//Fool's day https://clck.ru/9TFat
	public void SocialNetworks ()
	{
		Application.OpenURL ("https://vk.com/");
	}
	[SerializeField]
	private GameObject quitPanel;
	public void FakeChoice ()
	{
		quitPanel.SetActive (true);
	}
}
