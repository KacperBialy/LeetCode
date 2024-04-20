namespace LeetCode.ScoreOfString;

public static class Solution
{
    // https://leetcode.com/problems/score-of-a-string
    public static int ScoreOfString(string s)
    {
        var score = 0;
        
        for (var i = 1; i < s.Length; i++)
        {
            var diff = s[i - 1] - s[i];
            score += Math.Abs(diff);
        }

        return score;
    }
}