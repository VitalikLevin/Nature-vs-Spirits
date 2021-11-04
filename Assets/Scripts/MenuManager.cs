using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour 
{
	public void PlayGame ()
	{
		SceneManager.LoadScene (1);
	}
	public void QuitGame ()
	{
		Application.Quit ();
	}
	public void HidePanel (GameObject obj)
	{
		obj.SetActive (false);
	}
	public void ShowPanel (GameObject obj)
	{
		obj.SetActive (true);
	}
}
