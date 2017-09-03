/*
14. Longest Common Prefix  Difficulty: Easy

Write a function to find the longest common prefix string amongst an array of strings. 

*/

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length < 1) return "";
        Array.Sort(strs);

        int i = 0;
        string FirstString = strs[0];
        string LastString = strs[strs.Length - 1];

        while (i < FirstString.Length)
        {
            if (FirstString[i] == LastString[i])
                i++;
            else
                break;
        }

        return strs[0].Substring(0, i);
    }
}