using LeetTest.Models;

IsValidBST(new TreeNode(5, new TreeNode(4), new TreeNode(6, new TreeNode(3), new TreeNode(7))));
// DFS algorithm
bool IsValidBST(TreeNode root)
{
    return ValidateBST(root, null, null);
}

bool ValidateBST(TreeNode root, TreeNode left, TreeNode right)
{
    if (root == null)
        return true;

    if ((right != null && root.val >= right.val) || (left != null && root.val <= left.val))
        return false;

    return ValidateBST(root.left, left, root) && ValidateBST(root.right, root, right);
}