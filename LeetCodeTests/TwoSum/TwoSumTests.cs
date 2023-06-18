using FluentAssertions;

namespace TestProject1.TwoSum;

[TestFixture]
public class TwoSumTests
{
    [TestCase(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
    [TestCase(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
    [TestCase(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
    [TestCase(new int[] { 10, 10, 3, 3 }, 6, new int[] { 2, 3 })]
    public void TwoSum(int[] nums, int target, int[] expected)
    {
        // arrange
        var twoSum = new LeetCode.TwoSum.Solution();

        // act
        var output = twoSum.TwoSum(nums, target);

        // assert
        output.Should().BeEquivalentTo(expected);
    }
}