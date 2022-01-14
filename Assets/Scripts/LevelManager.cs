using System;
using UnityEngine;

public class LevelManager : MonoBehaviour 
{
	[SerializeField]
	private Transform map;
	[SerializeField]
	private string levelMap;
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
		BlockScript newGround = Instantiate(grounds[groundIndex], map).GetComponent<BlockScript>();
		newGround.Setup(new Point(x, y), new Vector3(worldStart.x + (GroundSize * x), worldStart.y + (GroundSize * y), 0));
	}
	private string[] ReadLevel ()
	{
		TextAsset bindData = Resources.Load(levelMap) as TextAsset;
		string tmpData = bindData.text.Replace(Environment.NewLine, string.Empty);
		return tmpData.Split('-');
	}
}