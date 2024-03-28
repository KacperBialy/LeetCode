namespace LeetCode.ThreeSum;

// https://leetcode.com/problems/3sum/
public static class Solution
{
    public static IList<IList<int>> ThreeSum(int[] nums)
    {
        if (nums.Length is < 3 or > 3000)
            return [];

        Array.Sort(nums);

        var dictionary = new Dictionary<int, int>();
        for (var i = nums.Length - 1; i >= 0; i--)
        {
            dictionary.TryAdd(nums[i], i);
        }

        var result = new List<IList<int>>();
        for (var i = 0; i < nums.Length; i++)
        {
            if (i > 0 && nums[i - 1] == nums[i])
                continue;

            for (var j = i + 1; j < nums.Length; j++)
            {
                if (j > i + 1 && nums[j - 1] == nums[j])
                    continue;

                var sum = nums[i] + nums[j];
                if (dictionary.TryGetValue(-sum, out var index))
                {
                    if (index > i && index > j)
                        result.Add(new List<int> { nums[i], nums[j], nums[index] });
                }
            }
        }

        return result;
    }
}