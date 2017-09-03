/*
 387. First Unique Character in a String

    Total Accepted: 34188
    Total Submissions: 75778
    Difficulty: Easy
    Contributors: Admin

Given a string, find the first non-repeating character in it and return it's index. If it doesn't exist, return -1.

Examples:

s = "leetcode"
return 0.

s = "loveleetcode",
return 2.

*/
public class Solution
{
    public int FirstUniqChar(string s)
    {
        int[] list = new int[256];

        foreach (char ch in s.ToCharArray())
        {
            list[(int)ch]++;
        }
        for (int i = 0; i < s.Length; i++)
        {
            if (list[(int)s[i]] == 1) return i;
        }
        return -1;
    }
}