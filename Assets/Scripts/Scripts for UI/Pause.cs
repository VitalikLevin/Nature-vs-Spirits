using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
	/// <summary>
	/// A Unity panel
	/// </summary>
	[SerializeField]
	private GameObject pObj;
	/// <summary>
	/// Activates or deactivates "pObj"
	/// </summary>
	/// <param name="paused">Two values: True, False</param>
	public void pActive (bool paused) 
	{
		pObj.SetActive(paused);
	}	
	/// <summary>
	/// Changes the speed of the game
	/// </summary>
	/// <param name="gameSpeed">Values: 0 < gameSpeed < 1</param>
	public void WakeUp (float gameSpeed)
	{
		Time.timeScale = gameSpeed;
	}
	/// <summary>
	/// The initialization
	/// </summary>
	void Start ()
    {
		pActive (false);
          WakeUp (1.0f);
    }
}
