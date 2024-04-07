namespace LeetCode.SearchInsertPosition;

// https://leetcode.com/problems/search-insert-position
public static class Solution
{
    public static int SearchInsert(int[] nums, int target)
    {
        var index = Array.BinarySearch(nums, target);
        return index >= 0 ? index : ~index;
    }
}