using System.Collections;
using System.Text;

namespace LeetCode.AddBinary;

// https://leetcode.com/problems/add-binary
public static class Solution
{
    public static string AddBinary(string a, string b)
    {
        var result = new StringBuilder();
        
        var carry = 0;
        var i = a.Length - 1;
        var j = b.Length - 1;

        while (i >= 0 || j >= 0 || carry > 0)
        {
            var sum = carry;
            if (i >= 0)
            {
                sum += a[i--] - '0';
            }

            if (j >= 0)
            {
                sum += b[j--] - '0';
            }

            result.Append(sum % 2);
            carry = sum / 2;
        }

        return new string(result.ToString().Reverse().ToArray());
    }
}