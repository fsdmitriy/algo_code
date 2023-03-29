using LeetTest.Models;

KthSmallest(new TreeNode(3, new TreeNode(1, new TreeNode(2)), new TreeNode(4)), 1);

int KthSmallest(TreeNode root, int k)
{
    var stack = new Stack<TreeNode>();

    while (true)
    {
        while (root != null)
        {
            stack.Push(root);
            root = root.left;
        }

        root = stack.Pop();
        if (--k == 0) return root.val;

        root = root.right;
    }
}