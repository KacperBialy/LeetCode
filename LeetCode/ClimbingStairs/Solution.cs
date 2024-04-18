namespace LeetCode.ClimbingStairs;

// https://leetcode.com/problems/climbing-stairs/
public static class Solution
{
    public static int ClimbStairs(int n)
    {
        return GetNthFibonacci(n + 2);
    }


    private static int GetNthFibonacci(int n)
    {
        var number = n - 1;
        
        var fib = new int[number + 1];
        
        fib[0]= 0;
        fib[1] = 1;
        
        for (var i = 2; i <= number;i++)
        {
            fib[i] = fib[i - 2] + fib[i - 1];
        }
        
        return fib[number];
    }
}