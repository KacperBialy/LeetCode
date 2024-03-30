using FluentAssertions;
using LeetCode.PalindromeNumber;

namespace LeetCodeTests.PalindromeNumber;

public class PalindromeNumberTests
{
    [Theory]
    [InlineData(121)]
    [InlineData(999)]
    public void PalindromeNumber_WhenIntegerIsPalindrome_ShouldReturnTrue(int integer)
    {
        // Act
        var result = Solution.IsPalindrome(integer);

        // Assert
        result.Should()
            .Be(true);
    }    
    
    [Theory]
    [InlineData(-121)]
    [InlineData(10)]
    public void PalindromeNumber_WhenIntegerIsPalindrome_ShouldReturnFalse(int integer)
    {
        // Act
        var result = Solution.IsPalindrome(integer);

        // Assert
        result.Should()
            .Be(false);
    }
}