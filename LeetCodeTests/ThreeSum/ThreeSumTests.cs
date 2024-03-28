using FluentAssertions;
using LeetCode.ThreeSum;

namespace LeetCodeTests.ThreeSum;

public class ThreeSumTests
{
    [Fact]
    public void ThreeSum_WhenLongInput_ShouldReturnExpectedResult()
    {
        // act
        var result = Solution.ThreeSum([-1, 0, 1, 2, -1, -4]);
        
        // assert
        result.Should().BeEquivalentTo(new List<IList<int>>
        {
            new List<int> { -1, -1, 2 },
            new List<int> { -1, 0, 1 }
        });
    }    
    
    [Fact]
    public void ThreeSum_WhenShortInput_ShouldReturnExpectedResult()
    {
        // act
        var result = Solution.ThreeSum([0, 1, -1]);
        
        // assert
        result.Should().BeEquivalentTo(new List<IList<int>>
        {
            new List<int> { -1, 0, 1 }
        });
    }
    
    [Fact]
    public void ThreeSum_ShouldReturnEmptyResult()
    {
        // act
        var result = Solution.ThreeSum([0, 1, 1]);
        
        // assert
        result.Should().BeEmpty();
    }    
    
    [Fact]
    public void ThreeSum_WhenZerosOnly_ShouldReturnEmptyResult()
    {
        // act
        var result = Solution.ThreeSum([0, 0, 0]);
        
        // assert
        result.Should().BeEquivalentTo(new List<IList<int>>
        {
            new List<int> { 0, 0, 0 },
        });
    }
}