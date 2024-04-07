using FluentAssertions;
using LeetCode.SearchInsertPosition;

namespace LeetCodeTests.SearchInsertPosition;

public class SearchInsertPositionTests
{
    [Theory]
    [InlineData(new[] {1,3,5,6}, 0, 0)]
    [InlineData(new[] {1, 3, 5, 6}, 5, 2)]
    [InlineData(new[] {1, 3, 5, 6}, 2, 1)]
    [InlineData(new[] {1, 3, 5, 6}, 7, 4)]
    public void SearchInsertPosition(int[] nums, int target, int expectedIndex)
    {
        // Act
        var index = Solution.SearchInsert(nums, target);

        // Assert
        index.Should()
            .Be(expectedIndex);
    }
}