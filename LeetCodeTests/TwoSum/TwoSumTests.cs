using FluentAssertions;
using LeetCode.TwoSum;

namespace LeetCodeTests.TwoSum;

public class TwoSumTests
{
    [Theory]
    [InlineData(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
    [InlineData(new[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
    [InlineData(new[] { 3, 3 }, 6, new[] { 0, 1 })]
    [InlineData(new[] { 10, 10, 3, 3 }, 6, new[] { 2, 3 })]
    public void TwoSum(int[] nums, int target, int[] expected)
    {
        // act
        var output = Solution.TwoSum(nums, target);

        // assert
        output.Should()
            .BeEquivalentTo(expected);
    }
}