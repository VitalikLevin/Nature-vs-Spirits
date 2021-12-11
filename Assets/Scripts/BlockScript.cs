using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BlockScript : MonoBehaviour 
{
	private Transform block;
	private SpriteRenderer blockRenderer;
	private Color32 fullColor = new Color32 (255, 118, 118, 255);
	private Color32 emptyColor = new Color32 (96, 255, 90, 255);
	public bool IsEmpty { get; private set; }
	private void PlacePlant () 
	{
		GameObject newPlant = Instantiate(GameManager.Instance.ClickedBtn.PlantPrefab);
		newPlant.transform.position = new Vector3 (block.position.x, block.position.y, 0);
		newPlant.transform.SetParent(block);
		IsEmpty = false;
		ColorBlock(Color.white);
		GameManager.Instance.BuyPlant();
	}
	private void ColorBlock (Color32 newColor)
	{
		blockRenderer.color = newColor;
	}
	void OnMouseOver ()
	{
		if (!EventSystem.current.IsPointerOverGameObject() && GameManager.Instance.ClickedBtn != null)
		{
			if (IsEmpty = true)
			{
				ColorBlock(emptyColor);
			}
			if (IsEmpty = false)
			{
				ColorBlock(fullColor);
			}
			else if (Input.GetMouseButtonDown(0))
			{
				PlacePlant();
			}
		}
	}
	private void OnMouseExit ()
	{
		ColorBlock(Color.white);
	}
	void Start ()
	{
		block = GetComponent<Transform>();
		blockRenderer = GetComponent<SpriteRenderer>();
		IsEmpty = true;
	}
}
