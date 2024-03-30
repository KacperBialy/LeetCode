namespace LeetCode.PalindromeNumber;

// https://leetcode.com/problems/palindrome-number/
public static class Solution
{
    public static bool IsPalindrome(int x)
    {
        if (x < 0)
            return false;

        var originalNumber = x;
        var reversedNumber = 0;

        while (originalNumber > 0)
        {
            var digit = originalNumber % 10;
            reversedNumber = reversedNumber * 10 + digit;
            originalNumber /= 10;
        }

        return x == reversedNumber;
    }
}