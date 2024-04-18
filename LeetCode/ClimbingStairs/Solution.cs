namespace LeetCode.ClimbingStairs;

// https://leetcode.com/problems/climbing-stairs/
public static class Solution
{
    public static int ClimbStairs(int n)
    {
        var left = 1;
        var right = 1;
        
        for (var i = 0; i < n - 1; i++)
        {
            var temp = left;
            left += right;
            right = temp;
        }

        return left;
    }
}