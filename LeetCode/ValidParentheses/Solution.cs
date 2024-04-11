namespace LeetCode.ValidParentheses;

// https://leetcode.com/problems/valid-parentheses
public static class Solution {
    public static bool IsValid(string s)
    {
        var stack = new Stack<char>();

        foreach (var character in s)
        {
            switch (character)
            {
                case '(':
                    stack.Push(')');
                    continue;
                case '{':
                    stack.Push('}');
                    continue;
                case '[':
                    stack.Push(']');
                    continue;
            }

            if(stack.Count == 0 || stack.Pop() != character)
            {
                return false;
            }
        }
        
        return stack.Count == 0;
    }
}