namespace LeetCode.HarshadNumber;

public static class Solution
{
    // resolving https://leetcode.com/problems/harshad-number
    public static int SumOfTheDigitsOfHarshadNumber(int x)
    {
        var sum = x.ToString().Sum(number => int.Parse(number.ToString()));

        return x % sum == 0 ? sum : -1;
    }
}