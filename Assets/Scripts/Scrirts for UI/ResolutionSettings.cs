using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class ResolutionSettings : MonoBehaviour {

	public Dropdown dropdown;
	public Toggle toggle;
	public Toggle sounds;
	Resolution[] res;

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

	public void ScreenMode ()
	{
		toggle.isOn = Screen.fullScreen;
		if (Screen.fullScreen == true) 
		{
			PlayerPrefs.SetInt ("FullScreen", 1);
		} 
		else 
		{
			PlayerPrefs.SetInt ("FullScreen", 0);
		}
	}
	public void SetRes ()
	{
		Screen.SetResolution (res [dropdown.value].width, res [dropdown.value].height, Screen.fullScreen);
		PlayerPrefs.SetInt ("Resolution", dropdown.value);
	}
	public void DeleteSave ()
	{
		PlayerPrefs.DeleteKey ("Levels");
	}

	// Use this for initialization
	void Start () {

		if (PlayerPrefs.HasKey ("FullScreen")) {
			if (PlayerPrefs.GetInt ("FullScreen") == 0) {
				Screen.fullScreen = false;
				toggle.isOn = false;
			} else {
				Screen.fullScreen = true;
				toggle.isOn = true;
			}
		} 
		else 
		{
			Screen.fullScreen = true;
			toggle.isOn = true;
		}

		if (PlayerPrefs.HasKey ("Sounds")) {
			if (PlayerPrefs.GetInt ("Sounds") == 0) {
				AudioListener.volume = 0.0f;
				sounds.isOn = false;
			} else {
				AudioListener.volume = 1.0f;
				sounds.isOn = true;
			}
		} 
		else 
		{
			AudioListener.volume = 1.0f;
			sounds.isOn = true;
		}

		Resolution [] resolution  = Screen.resolutions;
		res = resolution.Distinct ().ToArray ();
		string[] strRes = new string[res.Length];
		for (int i = 0; i < res.Length; i++) 
		{
			// strRes [i] = res [i].ToString();
			strRes [i] = res [i].width.ToString () + "x" + res [i].height.ToString ();
		}
		//Dropdown
		dropdown.ClearOptions ();
		dropdown.AddOptions (strRes.ToList ());

		if (PlayerPrefs.HasKey ("Resolution")) 
		{
			dropdown.value = PlayerPrefs.GetInt ("Resolution");
			Screen.SetResolution (res [PlayerPrefs.GetInt ("Resolution")].width, res [PlayerPrefs.GetInt ("Resolution")].height, Screen.fullScreen);
		}
		else
		{
			dropdown.value = res.Length - 1;
			//Set default resolution
			Screen.SetResolution (res [res.Length - 1].width, res [res.Length - 1].height, Screen.fullScreen);
		}
	}
}
