using System.Collections.Generic;
public static class AStar 
{
	private static Dictionary<Point, Node> nodes;
	private static void CreateNodes ()
    {
        nodes = new Dictionary<Point, Node>();
        foreach (BlockScript blk in LevelManager.Instance.Blocks.Values)
        {
            nodes.Add(blk.GridPosition, new Node(blk));
        }
    }
}