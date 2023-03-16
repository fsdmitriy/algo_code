using LeetTest.Models;

IsSubtree(new TreeNode(3, new TreeNode(4, new TreeNode(1), new TreeNode(2, new TreeNode(0))), new TreeNode(5)), new TreeNode(4, new TreeNode(1), new TreeNode(2)));
IsSubtree(new TreeNode(3, new TreeNode(4, new TreeNode(1), new TreeNode(2)), new TreeNode(5)), new TreeNode(4, new TreeNode(1), new TreeNode(2)));
IsSubtree(new TreeNode(1, new TreeNode(1)), new TreeNode(1));

bool IsSubtree(TreeNode root, TreeNode subRoot)
{
    if (root == null)
        return false;

    if (IsSameTree(root, subRoot))
        return true;

    return IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
}

bool IsSameTree(TreeNode root, TreeNode subRoot)
{
    if (root == null && subRoot == null)
        return true;
    else if (root != null && subRoot == null)
        return false;
    else if (root == null && subRoot != null)
        return false;
    else if (root.val != subRoot.val)
        return false;

    return IsSameTree(root.left, subRoot.left) && IsSameTree(root.right, subRoot.right);
}