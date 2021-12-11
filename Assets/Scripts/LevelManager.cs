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
	[SerializeField]
	private bool isAir;
	[SerializeField]
	private Vector3 customPos;
	[SerializeField]
	private bool effectsOn;
	[SerializeField]
	private GameObject effects;

	void Start ()
	{
		CreateLevel ();
		IdealPosition ();
		CreateEffects ();
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
				if (isAir == true)
				{
					newTile.GetComponent<SpriteRenderer>().color = new Color (0f, 1f, 0f, 0.0f);
				}
			}
		}
	}
	private void IdealPosition ()
	{
		parent.position = new Vector3 (customPos.x, customPos.y, 0);
	}
	private void CreateEffects ()
	{
		if (effectsOn == true)
		{
			GameObject newEffect = Instantiate (effects);
			newEffect.transform.position = new Vector3 (10.3f, 7.2f, 1.5f);
			newEffect.transform.Rotate(180, 180, -169);
		}
	}
}
