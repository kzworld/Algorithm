/*
345. Reverse Vowels of a String  Difficulty: Easy
Write a function that takes a string as input and reverse only the vowels of a string.

Example 1:
 Given s = "hello", return "holle". 

Example 2:
 Given s = "leetcode", return "leotcede". 

*/

public class Solution
{
    public string ReverseVowels(string s)
    {
        string vowels = "aeiouAEIOU";
        char[] arr = s.ToCharArray();

        if (s.Length == 1) return s;

        int start = 0, end = s.Length - 1;

        while (start < end)
        {
            while (start < end && !vowels.Contains(arr[start]))
            {
                start++;
            }
            while (start < end && !vowels.Contains(arr[end]))
            {
                end--;
            }

            char temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
            start++;
            end--;
        }
        return new string(arr);
    }
}