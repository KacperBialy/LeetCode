namespace LeetCode.LengthOfLongestSubstring;

// https://leetcode.com/problems/longest-substring-without-repeating-characters/
public static class Solution
{
    public static int LengthOfLongestSubstring(string s)
    {
        var (nextSequenceIndex, firstSequenceLength) = FindFirstSequenceLength(0, s);
        var maxLength = firstSequenceLength;

        while (nextSequenceIndex != -1)
        {
            (nextSequenceIndex, firstSequenceLength) = FindFirstSequenceLength(nextSequenceIndex, s);
            maxLength = Math.Max(maxLength, firstSequenceLength);
        }

        return maxLength;
    }

    private static (int nextSequenceIndex, int length) FindFirstSequenceLength(int startIndex, string s)
    {
        var characterPositions = new Dictionary<char, int>();
        for (var index = startIndex; index < s.Length; index++)
        {
            var currentCharacter = s[index];
            if (!characterPositions.TryAdd(currentCharacter, index))
            {
                return (characterPositions[currentCharacter] + 1, characterPositions.Count);
            }
        }

        return (-1, characterPositions.Count);
    }
}