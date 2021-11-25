using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockScript : MonoBehaviour 
{
	private void PlacePlant () 
	{
		Debug.Log ("Nice");
	}
	void OnMouseOver ()
	{
		if (Input.GetMouseButtonDown(0))
		{
			PlacePlant();
		}
	}
}
