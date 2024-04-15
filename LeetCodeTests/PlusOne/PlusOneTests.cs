using System.Text;
using FluentAssertions;
using LeetCode.PlusOne;

namespace LeetCodeTests.PlusOne;

public class PlusOneTests
{
    [Theory]
    [InlineData(new[] {1, 2, 3}, new[] {1, 2, 4})]
    [InlineData(new[] {4, 3, 2, 1}, new[] {4, 3, 2, 2})]
    [InlineData(new[] {9,8,7,6,5,4,3,2,1,0}, new[] {9,8,7,6,5,4,3,2,1,1})]
    public void PlusOne_ShouldReturnExpectedResult(int[] digits, int[] expectedResult)
    {
        // Act
        var result = Solution.PlusOne(digits);

        // Assert
        result.Should()
            .BeEquivalentTo(expectedResult);
    }

}