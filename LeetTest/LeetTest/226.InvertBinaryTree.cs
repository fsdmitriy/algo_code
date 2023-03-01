using LeetTest.Models;

InvertTree(new TreeNode(4, new TreeNode(2, new TreeNode(1), new TreeNode(3)), new TreeNode(7, new TreeNode(6), new TreeNode(9))));

TreeNode InvertTree(TreeNode root)
{
    if (root == null)
        return null;

    var tmp = root.left;
    root.left = InvertTree(root.right);
    root.right = InvertTree(tmp);

    return root;
}