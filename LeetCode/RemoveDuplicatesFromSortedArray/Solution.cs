namespace LeetCode.RemoveDuplicatesFromSortedArray;

public static class Solution 
{
    // https://leetcode.com/problems/remove-duplicates-from-sorted-array
    public static int RemoveDuplicates(int[] nums)
    {
        if(nums.Length == 0)
            return 0;
        
        var k = 1;
        var previous = nums[0];
        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] != previous)
            {
                nums[k] = nums[i];
                k++;
            }
            previous = nums[i];
        }
        
        return k;
    }
}