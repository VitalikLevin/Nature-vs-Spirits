using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class OtherSettings : MonoBehaviour 
{
	/// <summary>
	/// This function must have a link
	/// </summary>
	/// <param name="link">A reference to something in Internet</param>
	public void OpenSomething (string link)
	{
		Application.OpenURL (link);
	}

	/// <summary>
    /// A Unity Gameobject with Toggle component
    /// </summary>
    public Toggle sounds;

	/// <summary>
    /// Edits the volume of music
    /// </summary>
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

	/// <summary>
    /// The initialization
    /// </summary>
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