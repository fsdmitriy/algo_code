using LeetTest.Models;

Console.WriteLine(MaxPathSum(new TreeNode(1, new TreeNode(2), new TreeNode(3))));
Console.WriteLine(MaxPathSum(new TreeNode(-10, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)))));
Console.WriteLine(MaxPathSum(new TreeNode(10, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)))));

int MaxPathSum(TreeNode root)
{
    int maxSum = root.val;
    DfsMaxPathSum(root, ref maxSum);
    return maxSum;
}

int DfsMaxPathSum(TreeNode root, ref int maxSum)
{
    if (root == null)
        return 0;

    int leftSum = DfsMaxPathSum(root.left, ref maxSum);
    int rightSum = DfsMaxPathSum(root.right, ref maxSum);

    leftSum = Math.Max(leftSum, 0);
    rightSum = Math.Max(rightSum, 0);

    maxSum = Math.Max(maxSum, root.val + leftSum + rightSum);

    return root.val + Math.Max(leftSum, rightSum);
}