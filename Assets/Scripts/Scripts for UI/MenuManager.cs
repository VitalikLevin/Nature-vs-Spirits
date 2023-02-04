using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour 
{
	public void PlayGame (int level)
	{
		SceneManager.LoadScene (level);
	}
	public void ShowPanel (GameObject panel)
	{
		panel.SetActive (true);
	}
    public void HidePanel (GameObject obj)
	{
		obj.SetActive (false);
	}
	public void QuitGame ()
	{
		Application.Quit ();
	}
}