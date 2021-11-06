using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour 
{
	[SerializeField]
	private GameObject tile;
	[SerializeField]
	private Transform parent;

	void Start ()
	{
		CreateLevel ();
		IdealPosition ();
	}
	private void CreateLevel ()
	{
		float tileSize = tile.GetComponent<SpriteRenderer> ().sprite.bounds.size.x;
		for (int y = 0; y < 5; y++)
		{
			for (int x = 0; x < 9; x++)
			{
				GameObject newTile = Instantiate (tile);
				newTile.transform.SetParent (parent);
				newTile.transform.position = new Vector3 (tileSize * x, tileSize * y, 0);
			}
		}
	}
	private void IdealPosition ()
	{
		parent.position = new Vector3 (-4.84f, -3.31f, 0);
	}
}
