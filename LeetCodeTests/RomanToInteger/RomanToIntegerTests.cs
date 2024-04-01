using FluentAssertions;
using LeetCode.RomanToInteger;

namespace LeetCodeTests.RomanToInteger;

public class RomanToIntegerTests
{
    [Theory]
    [InlineData("III", 3)]
    [InlineData("IV", 4)]
    [InlineData("IX", 9)]
    [InlineData("XL", 40)]
    [InlineData("LVIII", 58)]
    [InlineData("LX", 60)]
    [InlineData("XC", 90)]
    [InlineData("CD", 400)]
    [InlineData("D", 500)]
    [InlineData("CM", 900)]
    [InlineData("M", 1000)]
    [InlineData("MCMXCIV", 1994)]
    [InlineData("MMMCMXCIX", 3999)]
    
    public void RomanToInt_ShouldReturnExpected(string s, int expected)
    {
        // Arrange

        // Act
        var result = Solution.RomanToInt(s);

        // Assert
        result.Should().Be(expected);
    }
}