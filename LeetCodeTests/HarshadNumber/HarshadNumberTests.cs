using FluentAssertions;
using LeetCode.HarshadNumber;

namespace LeetCodeTests.HarshadNumber;

public class HarshadNumberTests
{
    [Theory]
    [InlineData(18, 9)]
    [InlineData(20, 2)]
    [InlineData(132, 6)]
    [InlineData(10010, 2)]
    public void SumOfTheDigitsOfHarshadNumber_ShouldReturnsSum_WhenHarshadNumber(int number, int expectedSum)
    {
        // act
        var sum = Solution.SumOfTheDigitsOfHarshadNumber(number);

        // assert
        sum.Should().Be(expectedSum);
    }
    
    [Theory]
    [InlineData(19)]
    [InlineData(997)]
    [InlineData(11111)]
    public void SumOfTheDigitsOfHarshadNumber_ShouldReturnsMinusOne_WhenNotHarshadNumber(int number)
    {
        // act
        var sum = Solution.SumOfTheDigitsOfHarshadNumber(number);

        // assert
        sum.Should().Be(-1);
    }
}