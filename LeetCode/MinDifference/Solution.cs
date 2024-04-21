namespace LeetCode.MinDifference;

public static class Solution
{
    public static int MinDifference(int[] nums)
    {
        if (nums.Length <= 4)
        {
            return 0;
        }

        Array.Sort(nums);

        var minDifference = Math.Min(nums[^1] - nums[3], nums[^2] - nums[2]);
        minDifference = Math.Min(minDifference, nums[^3] - nums[1]);
        minDifference = Math.Min(minDifference, nums[^4] - nums[0]);

        return minDifference;
    }
}