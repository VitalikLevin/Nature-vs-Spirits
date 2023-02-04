using UnityEngine;
using UnityEngine.EventSystems;
public class BlockScript : MonoBehaviour 
{
	private Transform block;
	[SerializeField]
	private Color32 fullColor;
	[SerializeField]
	private Color32 emptyColor;
	public bool IsEmpty { get; private set; }
	public Point GridPosition { get; private set; }
    public SpriteRenderer BlockRenderer { get; set; }
    public bool DebugFoo { get; set; }
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
		BlockRenderer.color = newColor;
	}
	void OnMouseOver ()
	{
		if (!EventSystem.current.IsPointerOverGameObject() && GameManager.Instance.ClickedBtn != null)
		{
			if (IsEmpty == true && !DebugFoo)
			{
				ColorBlock(emptyColor);
				if (Input.GetMouseButtonDown(0))
				{
					PlacePlant();
				}
			}
			if (IsEmpty == false && !DebugFoo)
			{
				ColorBlock(fullColor);
			}
		}
	}
	private void OnMouseExit ()
	{
        if (!DebugFoo)
        {
			ColorBlock(new Color32(244, 244, 244, 255));
        }
	}
	void Start ()
	{
		block = GetComponent<Transform>();
		BlockRenderer = GetComponent<SpriteRenderer>();
		IsEmpty = true;
	}
	public void Setup (Point gridPos, Vector3 wPos)
	{
		this.GridPosition = gridPos;
		transform.position = wPos;
	}
}