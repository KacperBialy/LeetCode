using FluentAssertions;
using LeetCode.ScoreOfString;

namespace LeetCodeTests.ScoreOfString;

public class ScoreOfStringTests
{
    [Theory]
    [InlineData("hello", 13)]
    [InlineData("zaz", 50)]
    public void ScoreOfString(string input, int expectedScore)
    {
        // Act
        var score = Solution.ScoreOfString(input);

        // Assert
        score.Should()
            .Be(expectedScore);
    }
}