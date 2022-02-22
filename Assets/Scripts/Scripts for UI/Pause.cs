using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
	private bool isPaused;
	[SerializeField]
	private GameObject pObj;
	public void pActive () 
	{
		isPaused = !isPaused;
		pObj.SetActive(isPaused);
		Time.timeScale = 0.0f;
	}
	public void WakeUp ()
	{
		Time.timeScale = 1.0f;
	}
	public void GoMain ()
	{
		SceneManager.LoadScene (0);
	}
	void Update () 
	{
		if (Input.GetKeyUp(KeyCode.Escape))
		{
			pActive ();
			if (isPaused == true)
			{
				WakeUp ();
			}
		}
	}
}
