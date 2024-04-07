using FluentAssertions;
using LeetCode.FindTheIndexOfTheFirstOccurrenceInAString;

namespace LeetCodeTests.FindTheIndexOfTheFirstOccurrenceInAString;

public class FindTheIndexOfTheFirstOccurrenceInAStringTests
{
    [Theory]
    [InlineData("sadbutsad", "sad", 0)]
    [InlineData("sadbutsad", "but", 3)]
    [InlineData("leetcode", "leeto", -1)]
    public void StrStr_ShouldReturnsCorrectIndex(
        string hayStack,
        string needle,
        int expectedIndex)
    {
        // act
        var index = Solution.StrStr(hayStack, needle);
        
        // assert
        index.Should()
            .Be(expectedIndex);
    }
}