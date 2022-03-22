using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour 
{
	/// <summary>
	/// Opens a Unity scene
	/// </summary>
	/// <param name="level">The number of a scene</param>
	public void PlayGame (int level)
	{
		SceneManager.LoadScene (level);
	}
	/// <summary>
	/// Shows a panel
	/// </summary>
	/// <param name="obj">The panel in Unity scene</param>
	public void ShowPanel (GameObject obj)
	{
		obj.SetActive (true);
	}
	/// <summary>
     /// Hides a panel
     /// </summary>
     /// <param name="obj">The panel in Unity scene</param>
    public void HidePanel (GameObject obj)
	{
		obj.SetActive (false);
	}
	/// <summary>
	/// Closes the app
	/// </summary>
	public void QuitGame ()
	{
		Application.Quit ();
	}
}