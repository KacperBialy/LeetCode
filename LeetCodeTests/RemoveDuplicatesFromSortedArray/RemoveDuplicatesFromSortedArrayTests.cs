using FluentAssertions;
using LeetCode.RemoveDuplicatesFromSortedArray;

namespace LeetCodeTests.RemoveDuplicatesFromSortedArray;

public class RemoveDuplicatesFromSortedArrayTests
{
    [Theory]
    [InlineData(new[] {1, 1, 2}, 2)]
    [InlineData(new[] {0, 0, 1, 1, 1, 2, 2, 3, 3, 4}, 5)]
    public void RemoveDuplicates_ShouldReturnExpectedResult(int[] nums, int expectedResult)
    {
        // Arrange

        // Act
        var result = Solution.RemoveDuplicates(nums);

        // Assert
        result.Should()
            .Be(expectedResult);
    }
}