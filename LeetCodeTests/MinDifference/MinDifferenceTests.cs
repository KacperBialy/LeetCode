using FluentAssertions;
using LeetCode.MinDifference;

namespace LeetCodeTests.MinDifference;

// Resolving https://leetcode.com/problems/minimum-difference-between-largest-and-smallest-value-in-three-moves
public class MinDifferenceTests
{
    [Theory]
    [InlineData(new[] { 5, 3, 2, 4 }, 0)]
    [InlineData(new[] { 1, 5, 0, 10, 14 }, 1)]
    public void ScoreOfString(int[] input, int expectedScore)
    {
        // Act
        var score = Solution.MinDifference(input);

        // Assert
        score.Should()
            .Be(expectedScore);
    }
}