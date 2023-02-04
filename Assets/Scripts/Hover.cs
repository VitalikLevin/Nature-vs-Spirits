using UnityEngine;
public class Hover : Singleton<Hover> 
{
	private SpriteRenderer spriteRenderer;
	private void FollowMouse ()
	{
		if (spriteRenderer.enabled == true)
		{
			transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			transform.position = new Vector3 (transform.position.x, transform.position.y, 0);
		}
	}
	public void Activate (Sprite sprite)
	{
		spriteRenderer.enabled = true;
		this.spriteRenderer.sprite = sprite;
	}
	public void Deactivate ()
	{
		this.spriteRenderer.sprite = null;
		GameManager.Instance.ClickedBtn = null;
	}
	void Update () 
	{
		FollowMouse();
	}
	void Start ()
	{
		spriteRenderer = GetComponent<SpriteRenderer>();
	}
}