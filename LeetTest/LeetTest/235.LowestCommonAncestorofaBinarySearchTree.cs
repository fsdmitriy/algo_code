using LeetTest.Models;

LowestCommonAncestor(new TreeNode(2, new TreeNode(1)), new TreeNode(2), new TreeNode(1));

LowestCommonAncestor(new TreeNode(6, new TreeNode(2, new TreeNode(0), new TreeNode(4, new TreeNode(3), new TreeNode(5))), new TreeNode(8, new TreeNode(7),
    new TreeNode(9))), new TreeNode(2), new TreeNode(8));

LowestCommonAncestor(new TreeNode(6, new TreeNode(2, new TreeNode(0), new TreeNode(4, new TreeNode(3), new TreeNode(5))), new TreeNode(8, new TreeNode(7),
    new TreeNode(9))), new TreeNode(2), new TreeNode(4));

TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
{
    if(p.val<root.val && q.val<root.val)
    { 
        return LowestCommonAncestor(root.left, p, q);
    }

    if(p.val>root.val && q.val > root.val)
    {
        return LowestCommonAncestor(root.right, p, q);
    }

    return root;
}