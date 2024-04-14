using FluentAssertions;
using LeetCode.RemoveElement;

namespace LeetCodeTests.RemoveElement;

public class RemoveElementTests
{
    [Theory]
    [InlineData(new[] { 3, 2, 2, 3 }, 3, 2)]
    [InlineData(new[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, 5)]
    public void RemoveElement_ShouldReturnCorrectLength(int[] input, int val, int expectedLength)
    {
        // act
        var length = Solution.RemoveElement(input, val);

        // act
        length.Should().Be(expectedLength);
    }

    [Theory]
    [InlineData(new[] { 3, 2, 2, 3 }, 3, new[] { 2, 2 })]
    [InlineData(new[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, new[] { 0, 1, 3, 0, 4 })]
    public void RemoveElement_ShouldRemoveAllValFromInput(int[] input, int val, int[] expectedModifiedInput)
    {
        // act
        var length = Solution.RemoveElement(input, val);

        // act
        input[..length].Should().BeEquivalentTo(expectedModifiedInput);
    }
}