using System.Text.RegularExpressions;

namespace LeetCode.FindTheIndexOfTheFirstOccurrenceInAString;

// https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string
public static class Solution
{
    public static int StrStr(string haystack,string needle)
    {
        var regex = new Regex(needle);
        var match = regex.Match(haystack);
        
        return match.Success ? match.Index : -1;
    }
}