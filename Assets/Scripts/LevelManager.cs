using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour 
{
	[SerializeField]
	private GameObject[] grounds;
	[SerializeField]
	private Vector3 customPos;
	public float GroundSize
	{
		get { return grounds[0].GetComponent<SpriteRenderer>().sprite.bounds.size.x; }
	}
	void Start ()
	{
		CreateLevel ();
	}
	private void CreateLevel ()
	{
		string[] mapData = ReadLevel();
		int mapX = mapData[0].ToCharArray().Length;
		int mapY = mapData.Length;
		for (int y = 0; y < mapY; y++)
		{
			char[] newGrounds = mapData[y].ToCharArray();
			for (int x = 0; x < mapX; x++)
			{
				PlaceGround (newGrounds[x].ToString(), x, y, customPos);
			}
		}
	}
	private void PlaceGround (string groundType, int x, int y, Vector3 worldStart)
	{
		int groundIndex = int.Parse(groundType);
		GameObject newGround = Instantiate(grounds[groundIndex]);
		newGround.transform.position = new Vector3 (customPos.x + (GroundSize * x), customPos.y + (GroundSize * y), 0);
	}
	private string[] ReadLevel ()
	{
		TextAsset bindData = Resources.Load("lawn_1") as TextAsset;
		string tmpData = bindData.text.Replace(Environment.NewLine, string.Empty);
		return tmpData.Split('-');
	}
}