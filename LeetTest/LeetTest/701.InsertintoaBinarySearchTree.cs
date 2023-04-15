using LeetTest.Models;

InsertIntoBST(new TreeNode(4, new TreeNode(2, new TreeNode(1), new TreeNode(3)), new TreeNode(7)), 5);

//Recursive implementation
TreeNode InsertIntoBST(TreeNode root, int val)
{
    if (root == null)
        return new TreeNode(val);

    if (root.val > val)
    {
        root.left = InsertIntoBST(root.left, val);
    }
    else if (root.val < val)
    {
        root.right = InsertIntoBST(root.right, val);
    }

    return root;
}

// in loop implementation
TreeNode InsertIntoBST(TreeNode root, int val)
{
    if (root == null)
    {
        return new TreeNode(val);
    }

    TreeNode currentNode = root;
    while (true)
    {
        if (currentNode.val > val)
        {
            if (currentNode.left == null)
            {
                currentNode.left = new TreeNode(val);
                break;
            }
            else
            {
                currentNode = currentNode.left;
            }
        }
        else
        {
            if (currentNode.right == null)
            {
                currentNode.right = new TreeNode(val);
                break;
            }
            else
            {
                currentNode = currentNode.right;
            }
        }
    }
    return root;
}