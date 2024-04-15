using System.Numerics;
using System.Text;

namespace LeetCode.PlusOne;

// https://leetcode.com/problems/plus-one
public static class Solution
{
    public static int[] PlusOne(int[] digits)
    {
        var stringBuilder = new StringBuilder();
        
        foreach (var digit in digits)
        {
            stringBuilder.Append(digit);
        }
        
        var number = BigInteger.Parse(stringBuilder.ToString()) + 1;
        
        return number.ToString()
            .Select(c => int.Parse(c.ToString()))
            .ToArray();
    }
}