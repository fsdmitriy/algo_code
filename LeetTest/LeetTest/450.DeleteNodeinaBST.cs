using LeetTest.Models;

DeleteNode(new TreeNode(50, new TreeNode(30, null, new TreeNode(40)), new TreeNode(70, new TreeNode(60), new TreeNode(80))), 50);
DeleteNode(new TreeNode(5, new TreeNode(3, new TreeNode(2), new TreeNode(4)), new TreeNode(6, null, new TreeNode(7))), 3);
DeleteNode(new TreeNode(5, new TreeNode(3, new TreeNode(2), new TreeNode(4)), new TreeNode(6, null, new TreeNode(7))), 0);
DeleteNode(new TreeNode(0), 0);
TreeNode DeleteNode(TreeNode root, int key)
{
    if (root == null)
        return root;

    if (root.val == key)
    {
        if (root.right == null) return root.left;
        else if (root.left == null) return root.right;

        TreeNode rigthMin = root.right;
        while (rigthMin.left != null)
        {
            rigthMin = rigthMin.left;
        }

        rigthMin.left = root.left;
        return root.right;
    }
    else if (root.val > key)
    {
        root.left = DeleteNode(root.left, key);
    }
    else
    {
        root.right = DeleteNode(root.right, key);
    }

    return root;
}