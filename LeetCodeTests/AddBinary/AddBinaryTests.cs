using LeetCode.AddBinary;

namespace LeetCodeTests.AddBinary;

public class AddBinaryTests
{
    
    [Theory]
    [InlineData("1", "0", "1")]
    [InlineData("0", "0", "0")]
    [InlineData("1", "1", "10")]
    [InlineData("11", "1", "100")]
    [InlineData("1010", "1011", "10101")]
    public void AddBinary_ShouldReturnSumOfTwoBinaryStrings(string a, string b, string expected)
    {
        // Act
        var result = Solution.AddBinary(a, b);
        
        // Assert
        Assert.Equal(expected, result);
    }
}