namespace LeetCode.TwoSum;

// https://leetcode.com/problems/two-sum/
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var dictionary = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];
            if (dictionary.TryGetValue(num, out var index))
                return new int[] { index, i };

            dictionary.TryAdd(target - num, i);
        }

        return Array.Empty<int>();
    }
}