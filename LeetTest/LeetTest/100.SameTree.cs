using LeetTest.Models;

IsSameTree(new TreeNode(1, new TreeNode(2), new TreeNode(3)), new TreeNode(1, new TreeNode(2), new TreeNode(3)));

bool IsSameTree(TreeNode p, TreeNode q)
{

    if (p == null && q == null)
        return true;
    else if (p != null && q == null)
        return false;
    else if (p == null && q != null)
        return false;
    else if (p.val != q.val)
        return false;

    return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
}