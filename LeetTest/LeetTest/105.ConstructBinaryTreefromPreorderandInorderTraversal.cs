using LeetTest.Models;

BuildTree(new int[] { 3, 9, 20, 15, 7 }, new int[] { 9, 3, 15, 20, 7 });
BuildTree(new int[] { -1 }, new int[] { -1 });

TreeNode BuildTree(int[] preorder, int[] inorder)
{
    return DoBuildTree(0, 0, inorder.Length - 1, preorder, inorder);
}

TreeNode DoBuildTree(int preStart, int inStart, int inEnd, int[] preorder, int[] inorder)
{
    if (preorder.Length == 0 && inorder.Length == 0)
        return null;

    if (preStart > preorder.Length - 1 || inStart > inEnd)
        return null;

    var root = new TreeNode(preorder[preStart]);

    var mid = Array.IndexOf(inorder, preorder[preStart]);

    root.left = DoBuildTree(preStart + 1, inStart, mid - 1, preorder, inorder);
    root.right = DoBuildTree(preStart + mid-inStart+1, mid + 1, inEnd, preorder, inorder);

    return root;
}