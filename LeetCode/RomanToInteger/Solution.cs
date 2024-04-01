namespace LeetCode.RomanToInteger;

// https://leetcode.com/problems/roman-to-integer
public static class Solution
{
    public static int RomanToInt(string s)
    {
        var integer = 0;

        for (var index = 0; index < s.Length - 1; index++)
        {
            var currentSymbolValue = RomanNumeralToIntegerMap[s[index]];
            var nextSymbolValue = RomanNumeralToIntegerMap[s[index + 1]];
            
            if (currentSymbolValue < nextSymbolValue)
            {
                integer -= currentSymbolValue;
            }
            else
            {
                integer += currentSymbolValue;
            }
        }

        return integer + RomanNumeralToIntegerMap[s[^1]];
    }

    private static readonly Dictionary<char, int> RomanNumeralToIntegerMap = new()
    {
        { 'I', 1 },
        { 'V', 5 },
        { 'X', 10 },
        { 'L', 50 },
        { 'C', 100 },
        { 'D', 500 },
        { 'M', 1000 }
    };
}