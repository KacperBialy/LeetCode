using FluentAssertions;
using LeetCode.ClimbingStairs;

namespace LeetCodeTests.ClimbingStairsTests;

public class ClimbingStairsTests
{
    [Theory]
    [InlineData(2, 2)]
    [InlineData(3, 3)]
    public void ClimbStairs_ShouldReturnExpectedResult(int n, int expected)
    {
        // Act
        var output = Solution.ClimbStairs(n);
        
        // Assert
        output.Should()
            .Be(expected);
    }
}