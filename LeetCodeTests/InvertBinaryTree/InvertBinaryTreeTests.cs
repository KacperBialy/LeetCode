using FluentAssertions;
using LeetCode.InvertBinaryTree;

namespace LeetCodeTests.InvertBinaryTree;

public class InvertBinaryTreeTests
{
    [Fact]
    public void InvertTree_GivenSimpleTree_ShouldReturnCorrectInvertedTree()
    {
        // Arrange
        var root = new TreeNode(2)
        {
            Left = new TreeNode(1),
            Right = new TreeNode(3)
        };

        // Act
        var invertedTree = Solution.InvertTree(root);

        // Assert
        invertedTree.Val.Should().Be(2);
        invertedTree.Left.Val.Should().Be(3);
        invertedTree.Right.Val.Should().Be(1);
    }
    
    [Fact]
    public void InvertTree_GivenComplexTree_ShouldReturnCorrectInvertedTree()
    {
        // Arrange
        var root = new TreeNode(4)
        {
            Left = new TreeNode(2)
            {
                Left = new TreeNode(1),
                Right = new TreeNode(3)
            },
            Right = new TreeNode(7)
            {
                Left = new TreeNode(6),
                Right = new TreeNode(9)
            }
        };

        // Act
        var invertedTree = Solution.InvertTree(root);

        // Assert
        invertedTree.Val.Should().Be(4);
        invertedTree.Left.Val.Should().Be(7);
        invertedTree.Right.Val.Should().Be(2);
        invertedTree.Left.Left.Val.Should().Be(9);
        invertedTree.Left.Right.Val.Should().Be(6);
        invertedTree.Right.Left.Val.Should().Be(3);
        invertedTree.Right.Right.Val.Should().Be(1);
    }
}