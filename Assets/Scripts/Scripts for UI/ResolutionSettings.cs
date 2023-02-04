using System.Linq;
using UnityEngine;
using UnityEngine.UI;
public class ResolutionSettings : MonoBehaviour 
{
    public Dropdown resDropdown;
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
		Screen.SetResolution (res [resDropdown.value].width, res [resDropdown.value].height, Screen.fullScreen);
		PlayerPrefs.SetInt ("Resolution", resDropdown.value);
	}
	void Start () 
	{
		Resolution [] resolution  = Screen.resolutions;
		res = resolution.Distinct ().ToArray ();
		string[] strRes = new string[res.Length];
		for (int i = 0; i < res.Length; i++) 
		{
			strRes [i] = res [i].width.ToString () + "x" + res [i].height.ToString ();
		}
		resDropdown.ClearOptions ();
		resDropdown.AddOptions (strRes.ToList ());
		if (PlayerPrefs.HasKey ("Resolution")) 
		{
			resDropdown.value = PlayerPrefs.GetInt ("Resolution");
			Screen.SetResolution (res [PlayerPrefs.GetInt ("Resolution")].width, res [PlayerPrefs.GetInt ("Resolution")].height, Screen.fullScreen);
		}
		else
		{
			resDropdown.value = res.Length - 1;
			Screen.SetResolution (res [res.Length - 1].width, res [res.Length - 1].height, Screen.fullScreen);
		}
	}
    void Update ()
	{
		ScreenMode ();
	}
}