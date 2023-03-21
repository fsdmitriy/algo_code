using LeetTest.Models;

LevelOrder(new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7))));
LevelOrder(new TreeNode(3, new TreeNode(9, new TreeNode(8), new TreeNode(6)), new TreeNode(20, new TreeNode(15), new TreeNode(7))));

// Breadth-first search algorithm
IList<IList<int>> LevelOrder(TreeNode root)
{
    var result = new List<IList<int>>();
    var queue = new Queue<TreeNode>();
    queue.Enqueue(root);

    while (queue.Count > 0)
    {
        var qLen = queue.Count;
        var range = new List<int>();
        for (int i = 0; i < qLen; i++)
        {
            var node = queue.Dequeue();
            if (node != null)
            {
                range.Add(node.val);
                queue.Enqueue(node.left);
                queue.Enqueue(node.right);
            }
        }

        if(range.Count>0)
            result.Add(range);
    }

    return result;
}