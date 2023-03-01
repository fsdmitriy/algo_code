using LeetTest.Models;

MaxDepth(new TreeNode(3, new TreeNode(8, new TreeNode(20, new TreeNode(15), new TreeNode(7)))));


int MaxDepth(TreeNode root)
{
    if (root == null)
        return 0;

    return Math.Max(MaxDepth(root.left), MaxDepth(root.right)) + 1;
}

int MaxDepthDetailed(TreeNode root)
{
    if (root == null)
        return 0;

    return GetMaxGepth(root.left, root.right);
}

int GetMaxGepth(TreeNode left, TreeNode right)
{
    int leftDepth = 1, rightDepth = 1;

    if (left != null)
    {
        leftDepth += GetMaxGepth(left.left, left.right);
    }

    if (right != null)
    {
        rightDepth += GetMaxGepth(right.left, right.right);
    }

    return Math.Max(leftDepth, rightDepth);
}