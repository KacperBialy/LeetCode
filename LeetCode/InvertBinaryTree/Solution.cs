namespace LeetCode.InvertBinaryTree;

public sealed class TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
{
    public int Val = val;
    public TreeNode? Left = left;
    public TreeNode? Right = right;
}

// https://leetcode.com/problems/invert-binary-tree
public static class Solution
{
    public static TreeNode? InvertTree(TreeNode? root)
    {
        if (root == null)
            return null;
        
        var left = InvertTree(root.Left);
        var right = InvertTree(root.Right);
        
        root.Left = right;
        root.Right = left;
        
        return root;
    }
}