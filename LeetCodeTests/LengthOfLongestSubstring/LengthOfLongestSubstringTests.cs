using FluentAssertions;
using LeetCode.LengthOfLongestSubstring;

namespace LeetCodeTests.LengthOfLongestSubstring;

public class LengthOfLongestSubstringTests
{
    [Theory]
    [InlineData("abcabcbb", 3)]
    [InlineData("bbbbb", 1)]
    [InlineData("pwwkew", 3)]
    [InlineData("dvdf", 3)]
    [InlineData(" ", 1)]
    public void LengthOfLongestSubstring_ShouldReturnExpectedLength(
        string input,
        int expectedLength)
    {
        // act
        var output = Solution.LengthOfLongestSubstring(input);

        // assert
        output.Should()
            .Be(expectedLength);
    }
}