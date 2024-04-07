using System.Text;

namespace LeetCode.LongestCommonPrefix;

// https://leetcode.com/problems/longest-common-prefix/
public static class Solution
{
    public static string LongestCommonPrefix(string[] strs)
    {
        var prefixBuilder = new StringBuilder();

        var min = strs.Min(s => s.Length);

        for (var i = 0; i < min; i++)
        {
            for (var j = 1; j < strs.Length; j++)
            {
                if (strs[j - 1][i] != strs[j][i])
                {
                    return prefixBuilder.ToString();
                }
            }
            prefixBuilder.Append(strs[0][i]);
        }

        return prefixBuilder.ToString();
    }
}