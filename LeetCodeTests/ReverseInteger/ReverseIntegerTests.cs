using FluentAssertions;
using LeetCode.ReverseInteger;

namespace LeetCodeTests.ReverseInteger;

public class ReverseIntegerTests
{
    [Fact]
    public void ReverseInteger_WhenInputIsPositiveNumber_ShouldReturnReversedInteger()
    {
        // arrange
        const int input = 123;
        
        // act
        var reversedInteger = Solution.ReverseInteger(input);

        // assert
        reversedInteger.Should()
            .Be(321);
    }
    
    [Fact]
    public void ReverseInteger_WhenInputIsNegativeNumber_ShouldReturnReversedInteger()
    {
        // arrange
        const int input = -123;
        
        // act
        var reversedInteger = Solution.ReverseInteger(input);

        // assert
        reversedInteger.Should()
            .Be(-321);
    }    
    
    [Fact]
    public void ReverseInteger_WhenInputContainsZeroAtTheEnd_ShouldReturnReversedInteger()
    {
        // arrange
        const int input = 120;
        
        // act
        var reversedInteger = Solution.ReverseInteger(input);

        // assert
        reversedInteger.Should()
            .Be(21);
    }    
    
    [Fact]
    public void ReverseInteger_WhenInputIsTooBig_ShouldReturnReversedInteger()
    {
        // arrange
        const int input = 1534236469;
        
        // act
        var reversedInteger = Solution.ReverseInteger(input);

        // assert
        reversedInteger.Should()
            .Be(0);
    }    
    
    [Fact]
    public void ReverseInteger_WhenInputIsTooSmall_ShouldReturnReversedInteger()
    {
        // arrange
        const int input = -2147483648;
        
        // act
        var reversedInteger = Solution.ReverseInteger(input);

        // assert
        reversedInteger.Should()
            .Be(0);
    }
}