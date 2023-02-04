using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AStarDebugger : MonoBehaviour 
{
	private BlockScript start, goal;
    [SerializeField]
    private Sprite blankBlock;
	private void ClickBlock ()
    {
        if (Input.GetMouseButtonDown(2))
        {
			RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.collider !=null)
            {
				BlockScript tmp = hit.collider.GetComponent<BlockScript>();
                if (tmp != null)
                {
                    if (start == null)
                    {
                        start = tmp;
                        start.DebugFoo = true;
                        start.BlockRenderer.sprite = blankBlock;
                        start.BlockRenderer.color = new Color32(255, 132, 0, 255);
                    }
                    else if (goal == null)
                    {
                        goal = tmp;
                        goal.DebugFoo = true;
                        goal.BlockRenderer.sprite = blankBlock;
                        goal.BlockRenderer.color = new Color32(255, 0, 0, 255);
                    }
                }
            }
        }
    }
	void Update () 
	{
        ClickBlock();
	}
}