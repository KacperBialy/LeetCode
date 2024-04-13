namespace LeetCode.LengthOfLastWord;

public static class Solution
{
    // https://leetcode.com/problems/length-of-last-word
    public static int LengthOfLastWord(string s)
    {
        var lastWord = s.Trim()
            .Split(" ")
            .TakeLast(1);

        return lastWord.First().Length;
    }
}