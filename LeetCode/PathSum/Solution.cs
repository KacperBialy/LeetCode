namespace LeetCode.PathSum;

// https://leetcode.com/problems/path-sum
public static class Solution
{
    public static bool HasPathSum(TreeNode? root, int targetSum)
    {
        if (root == null)
            return false;

        if (root.Left == null && root.Right == null)
            return targetSum == root.Val;

        return HasPathSum(root.Left, targetSum - root.Val) 
               || HasPathSum(root.Right, targetSum - root.Val);
    }
}

public record TreeNode(int Val, TreeNode? Left = null, TreeNode? Right = null);