using UnityEngine;
using UnityEngine.SceneManagement;
public class Pause : MonoBehaviour
{
	[SerializeField]
	private GameObject pObj;
	public void pActive (bool paused) 
	{
		pObj.SetActive(paused);
	}
	public void WakeUp (float gameSpeed)
	{
		Time.timeScale = gameSpeed;
	}
	public void RestartLvl ()
    {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
	void Start ()
    {
		pActive (false);
        WakeUp (1.0f);
    }
}
