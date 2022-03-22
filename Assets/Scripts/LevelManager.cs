using System;
using UnityEngine;

public class LevelManager : MonoBehaviour 
{
	///<summary>
	///Parent of all blocks
	///</summary>
	[SerializeField]
	private Transform map;
	///<summary>
	///Name of a "TXT file" with level configuration
	///</summary>
	[SerializeField]
	private string levelMap;
	///<summary>
	///A list with blocks (0 > grounds[] > 10)
	///</summary>
	[SerializeField]
	private GameObject[] grounds;
	/// <summary>
    /// The position of the first block
    /// </summary>
	[SerializeField]
	private Vector3 customPos;
	/// <summary>
    /// The size of block's texture (GroundSize > 0)
    /// </summary>
    public float GroundSize
	{
		get { return grounds[0].GetComponent<SpriteRenderer>().sprite.bounds.size.x; }
	}
	/// <summary>
    /// The initialization
    /// </summary>
    void Start ()
	{
		CreateLevel ();
	}
	/// <summary>
    /// Creates a levelmap
    /// </summary>
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
	/// <summary>
    /// Creates a block using the information from "levelmap"
    /// </summary>
    /// <param name="groundType">Default is null</param>
    /// <param name="x">The Point.X position a block</param>
    /// <param name="y">The Point.Y position a block</param>
    /// <param name="worldStart">Default value is 0,0,0</param>
    private void PlaceGround (string groundType, int x, int y, Vector3 worldStart)
	{
		int groundIndex = int.Parse(groundType);
		BlockScript newGround = Instantiate(grounds[groundIndex], map).GetComponent<BlockScript>();
		newGround.Setup(new Point(x, y), new Vector3(worldStart.x + (GroundSize * x), worldStart.y + (GroundSize * y), 0));
	}
	/// <summary>
    /// Reads "levelmap" file
    /// </summary>
    /// <returns>Lots of numbers</returns>
    private string[] ReadLevel ()
	{
		TextAsset bindData = Resources.Load(levelMap) as TextAsset;
		string tmpData = bindData.text.Replace(Environment.NewLine, string.Empty);
		return tmpData.Split('-');
	}
}