/* 383. Ransom Note

    Total Accepted: 33915
    Total Submissions: 73958
    Difficulty: Easy
    Contributors: Admin

Given an arbitrary ransom note string and another string containing letters from all the magazines, write a function that will return true if the ransom note can be constructed from the magazines ; otherwise, it will return false.

Each letter in the magazine string can only be used once in your ransom note.

Note:
You may assume that both strings contain only lowercase letters.

canConstruct("a", "b") -> false
canConstruct("aa", "ab") -> false
canConstruct("aa", "aab") -> true
*/
public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        int[] arr = new int[26];

        for (int i = 0; i < magazine.Length; i++)
        {
            arr[magazine[i] - 'a']++;
        }
        for (int i = 0; i < ransomNote.Length; i++)
        {
            if (--arr[ransomNote[i] - 'a'] < 0)
            {
                return false;
            }
        }
        return true;
    }
}