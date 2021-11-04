using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour 
{
	[SerializeField]
	private GameObject tile;
	void Start ()
	{
		CreateLevel ();
	}
	private void CreateLevel ()
	{
		float tileSize = tile.GetComponent<SpriteRenderer> ().sprite.bounds.size.x;
		for (int y = 0; y < 5; y++)
		{
			for (int x = 0; x < 9; x++)
			{
				GameObject newTile = Instantiate (tile);
				newTile.transform.position = new Vector3 (tileSize * x, tileSize * y, 0);
			}
		}
	}
}
