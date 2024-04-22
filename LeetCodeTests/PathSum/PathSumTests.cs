using FluentAssertions;
using LeetCode.PathSum;

namespace LeetCodeTests.PathSum;

public class PathSumTests
{
    [Theory]
    [MemberData(nameof(HasSumTestData))]
    public void TestName(TreeNode? node, int targetSum, bool expectedResult)
    {
        Solution.HasPathSum(node, targetSum)
            .Should()
            .Be(expectedResult);
    }

    public static IEnumerable<object[]> HasSumTestData()
    {
        yield return
        [
            new TreeNode(5)
            {
                Left = new TreeNode(4)
                {
                    Left = new TreeNode(11)
                    {
                        Left = new TreeNode(7),
                        Right = new TreeNode(2)
                    }
                },
                Right = new TreeNode(8)
                {
                    Left = new TreeNode(13),
                    Right = new TreeNode(4)
                    {
                        Right = new TreeNode(1)
                    }
                }
            },
            22,
            true
        ];

        yield return
        [
            new TreeNode(1)
            {
                Left = new TreeNode(2)
            },
            1,
            false
        ];

        yield return
        [
            new TreeNode(1)
            {
                Left = new TreeNode(2),
                Right = new TreeNode(3)
            },
            5,
            false
        ];
    }
}