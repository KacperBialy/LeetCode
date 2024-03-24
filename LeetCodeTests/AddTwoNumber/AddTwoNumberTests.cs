using FluentAssertions;
using LeetCode.AddTwoNumber;
using TestProject1.AddTwoNumber;

namespace LeetCodeTests.AddTwoNumber;

public class AddTwoNumberTests
{
    [Theory]
    [MemberData(nameof(DataProvider))]
    public void AddTwoNumber_GivenListNodes_ShouldReturnsExpectedListNode(ListNode firstListRoot,
        ListNode secondListRoot, ListNode expected)
    {
        // act
        var output = Solution.Add(firstListRoot, secondListRoot);

        // assert
        output.Should()
            .BeEquivalentTo(expected);
    }

    public static IEnumerable<object[]> DataProvider()
    {
        var listNode1Test1 = CreateLinkedList(2, 4, 3);
        var listNode2Test1 = CreateLinkedList(5, 6, 4);
        var outputTest1 = CreateLinkedList(7, 0, 8);

        yield return [listNode1Test1, listNode2Test1, outputTest1];

        var listNode1Test2 = CreateLinkedList(0);
        var listNode2Test2 = CreateLinkedList(0);
        var outputTest2 = CreateLinkedList(0);

        yield return [listNode1Test2, listNode2Test2, outputTest2];

        var listNode1Test3 = CreateLinkedList(9, 9, 9, 9, 9, 9, 9);
        var listNode2Test3 = CreateLinkedList(9, 9, 9, 9);
        var outputTest3 = CreateLinkedList(8, 9, 9, 9, 0, 0, 0, 1);

        yield return [listNode1Test3, listNode2Test3, outputTest3];
    }

    private static ListNode CreateLinkedList(params int[] numbers)
    {
        var head = new ListNode(numbers[0]);
        var current = head;

        for (var i = 1; i < numbers.Length; i++)
        {
            var newNode = new ListNode(numbers[i]);
            current.Next = newNode;
            current = newNode;
        }

        return head;
    }
}