using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class ResolutionSettings : MonoBehaviour 
{
	public Dropdown dropdown;
	Resolution[] res;
	public void ScreenMode ()
	{
		if (Input.GetKey(KeyCode.F))
		{
			Screen.fullScreen = !Screen.fullScreen;
		}
	}
	public void SetRes ()
	{
		Screen.SetResolution (res [dropdown.value].width, res [dropdown.value].height, Screen.fullScreen);
		PlayerPrefs.SetInt ("Resolution", dropdown.value);
	}
	void Start () 
	{
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
	void Update ()
	{
		ScreenMode ();
	}
}
