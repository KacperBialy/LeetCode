namespace LeetCode.ReverseInteger;

// https://leetcode.com/problems/reverse-integer/
public static class Solution
{
    private static readonly double MinValue = -Math.Pow(2, 31);
    private static readonly double MaxValue = Math.Pow(2, 31) - 1;

    public static int ReverseInteger(int x)
    {
        var valueAsString = x.ToString();
        
        var isNegative = x < 0;
        
        var reversedArray = isNegative
            ? valueAsString.Skip(1).Reverse().ToArray()
            : valueAsString.Reverse().ToArray();
        
        var reversedValueAsString = new string(reversedArray);

        var sign = isNegative ? "-" : "";
        var resultString = sign + reversedValueAsString;
        
        return int.TryParse(resultString, out var result) 
            ? result 
            : 0;
    }
}