using System.Collections;
using UnityEngine;
public class Node 
{
	public Point GridPosition { get; private set; }
	public BlockScript BlockRef { get; private set; }
	public Node (BlockScript blockRef)
	{
		this.BlockRef = blockRef;
		this.GridPosition = blockRef.GridPosition;
	}
}