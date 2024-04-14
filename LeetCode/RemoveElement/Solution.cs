namespace LeetCode.RemoveElement;

public static class Solution
{
    // https://leetcode.com/problems/remove-element
    public static int RemoveElement(int[] nums, int val)
    {
        var index = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[index++] = nums[i];
            }
        }
        
        return index;
    }
}