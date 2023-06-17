using FluentAssertions;
using FluentAssertions.Execution;

namespace TestProject1.AddTwoNumber;

[TestFixture]
public class AddTwoNumberTests
{
    [TestCaseSource(nameof(DataProvider))]
    public void AddTwoNumber(ListNode firstListRoot, ListNode secondListRoot, ListNode expected)
    {
        // arrange
        var addTwoNumber = new LeetCode.AddTwoNumber.AddTwoNumber();

        // act
        var output = addTwoNumber.Add(firstListRoot, secondListRoot);

        // assert
        output.Should().BeEquivalentTo(expected);
    }

    public static IEnumerable<ListNode[]> DataProvider()
    {
        var listNode1Test1 = CreateLinkedList(2,4,3);
        var listNode2Test1 = CreateLinkedList(5,6,4);
        var outputTest1 = CreateLinkedList(7,0,8);
        
        yield return new[] { listNode1Test1, listNode2Test1, outputTest1 };
        
        var listNode1Test2 = CreateLinkedList(0);
        var listNode2Test2 = CreateLinkedList(0);
        var outputTest2 = CreateLinkedList(0);
        
        yield return new[] { listNode1Test2, listNode2Test2, outputTest2 };
        
        var listNode1Test3 = CreateLinkedList(9, 9, 9, 9, 9, 9, 9);
        var listNode2Test3 = CreateLinkedList(9,9,9,9);
        var outputTest3 = CreateLinkedList(8, 9, 9, 9, 0, 0, 0, 1);

        yield return new[] { listNode1Test3, listNode2Test3, outputTest3 };
    }

    private static ListNode CreateLinkedList(params int[] numbers)
    {
        var head = new ListNode(numbers[0]);
        var current = head;

        for (int i = 1; i < numbers.Length; i++)
        {
            var newNode = new ListNode(numbers[i]);
            current.Next = newNode;
            current = newNode;
        }
        
        return head;
    }
}