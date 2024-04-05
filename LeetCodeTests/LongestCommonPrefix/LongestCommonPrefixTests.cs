using FluentAssertions;
using LeetCode.LongestCommonPrefix;

namespace LeetCodeTests.LongestCommonPrefix;

public class LongestCommonPrefixTests
{
    [Fact]
    public void LongestCommonPrefix_WhenCommonPrefixExists_ReturnsCorrectPrefix()
    {
        // arrange
        string[] input = ["flower", "flow", "flight"];
        
        // act
        var prefix = Solution.LongestCommonPrefix(input);

        // assert
        prefix.Should()
            .Be("fl");
    }    
    
    [Fact]
    public void LongestCommonPrefix_WhenCommonPrefixNotExists_ShouldReturnEmptyPrefix()
    {
        // arrange
        string[] input = ["dog","racecar","car"];
        
        // act
        var prefix = Solution.LongestCommonPrefix(input);

        // assert
        prefix.Should()
            .Be(string.Empty);
    }
}