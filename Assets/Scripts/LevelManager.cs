using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour 
{
	[SerializeField]
	private GameObject tile;
	[SerializeField]
	private Transform parent;
	[SerializeField]
	private int customX;
	[SerializeField]
	private int customY;
	public Vector3 customPos;

	void Start ()
	{
		CreateLevel ();
		IdealPosition ();
	}
	private void CreateLevel ()
	{
		float tileSize = tile.GetComponent<SpriteRenderer> ().sprite.bounds.size.x;
		for (int y = 0; y < customY; y++)
		{
			for (int x = 0; x < customX; x++)
			{
				GameObject newTile = Instantiate (tile);
				newTile.transform.SetParent (parent);
				newTile.transform.position = new Vector3 (tileSize * x, tileSize * y, 0);
			}
		}
	}
	private void IdealPosition ()
	{
		parent.position = new Vector3 (customPos.x, customPos.y, 0);
	}
}
