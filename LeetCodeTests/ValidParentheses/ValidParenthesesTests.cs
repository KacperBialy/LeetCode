using FluentAssertions;
using LeetCode.ValidParentheses;

namespace LeetCodeTests.ValidParentheses;

public class ValidParenthesesTests
{
    [Theory]
    [InlineData("()", true)]
    [InlineData("()[]{}", true)]
    [InlineData("{[]}", true)]
    [InlineData("(]", false)]
    [InlineData("([)]", false)]
    [InlineData("(", false)]
    [InlineData(")", false)]
    public void IsValid_ShouldReturnExpectedResult(string input, bool expectedResult)
    {
        // Act
        var result = Solution.IsValid(input);

        // Assert
        result.Should().Be(expectedResult);
    }
}