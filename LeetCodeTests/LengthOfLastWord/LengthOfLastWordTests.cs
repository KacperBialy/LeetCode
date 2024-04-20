using System.Runtime.InteropServices;
using FluentAssertions;
using LeetCode.LengthOfLastWord;

namespace LeetCodeTests;

public class LengthOfLastWordTests
{
  [Theory]
  [InlineData("  ", 0)]
  [InlineData("Hello World", 5)]
  [InlineData("   fly me   to   the moon  ", 4)]
  [InlineData("luffy is still joyboy", 6)]
  public void LengthOfLastWord_ShouldReturnCorrectLentgh(string input, int expectedLength)
  {
    // act
    var length = Solution.LengthOfLastWord(input);
    
    // assert
    length.Should().Be(expectedLength);
  }
  
}