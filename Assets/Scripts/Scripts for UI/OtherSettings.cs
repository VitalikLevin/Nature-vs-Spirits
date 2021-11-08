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
	public GameObject quitPanel;
	public Transform canvas;
	public void FakeChoice ()
	{
		GameObject newPanel = Instantiate (quitPanel);
		newPanel.transform.SetParent (canvas);
	}
}
