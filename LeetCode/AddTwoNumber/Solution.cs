using System.Runtime.InteropServices.ComTypes;
using TestProject1.AddTwoNumber;

namespace LeetCode.AddTwoNumber;

// https://leetcode.com/problems/add-two-numbers/
public static class Solution
{
    public static ListNode Add(ListNode l1, ListNode l2)
    {
        var remainder = 0;
        var currentValue = l1.Val + l2.Val;

        if (currentValue >= 10)
        {
            currentValue -= 10;
            remainder = 1;
        }

        var head = new ListNode(currentValue);

        var current = head;
        var currentL1 = l1.Next;
        var currentL2 = l2.Next;


        while (currentL1 is not null || currentL2 is not null)
        {
            currentValue = (currentL1?.Val ?? 0) + (currentL2?.Val ?? 0) + remainder;

            remainder = 0;

            if (currentValue >= 10)
            {
                currentValue -= 10;
                remainder = 1;
            }

            var newNode = new ListNode(currentValue);
            current.Next = newNode;
            current = newNode;

            currentL1 = currentL1?.Next;
            currentL2 = currentL2?.Next;
        }

        if (remainder == 1)
            current.Next = new ListNode(remainder);

        return head;
    }
}