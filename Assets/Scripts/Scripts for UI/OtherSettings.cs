using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class OtherSettings : MonoBehaviour 
{
	//Fool's day https://clck.ru/9TFat
	public void SocialNetworks ()
	{
		Application.OpenURL ("https://vk.com/s_topgames");
	}
	public void BestPage ()
	{
		Application.OpenURL ("https://clck.ru/9TFat");
	}
	//Sounds
	public Toggle sounds;
	public void Sounds ()
	{
		if (sounds.isOn == true) 
		{
			PlayerPrefs.SetInt ("Sounds", 1);
			AudioListener.volume = 1.0f;
		} 
		else 
		{
			PlayerPrefs.SetInt ("Sounds", 0);
			AudioListener.volume = 0.0f;
		}
	}
	void Start ()
	{
		if (PlayerPrefs.HasKey ("Sounds")) 
		{
			if (PlayerPrefs.GetInt ("Sounds") == 0) 
			{
				AudioListener.volume = 0.0f;
				sounds.isOn = false;
			} 
			else 
			{
				AudioListener.volume = 1.0f;
				sounds.isOn = true;
			}
		} 
		else 
		{
			AudioListener.volume = 1.0f;
			sounds.isOn = true;
		}
	}
}