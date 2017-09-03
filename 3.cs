/*3. Longest Substring Without Repeating Characters

    Total Accepted: 179160
    Total Submissions: 778205
    Difficulty: Medium

Given a string, find the length of the longest substring without repeating characters.

Examples:

Given "abcabcbb", the answer is "abc", which the length is 3.

Given "bbbbb", the answer is "b", with the length of 1.

Given "pwwkew", the answer is "wke", with the length of 3. Note that the answer must be a substring, "pwke" is a subsequence and not a substring.*/
public class Solution {
	public int LengthOfLongestSubstring(string s) {
		int p = 0;
		int result = 0;
		for(int a = 0;a<s.Length;a++) /*need two pointers a is faster; b is slower*/
		{
			for(int b = p;b<a;b++)
			{
				result = Math.Max(result, a-b); /* To store max length of characters without duplicates.*/ 
				if(s[a] == s[b])
				{
					p = b+1;break; /*mark as current position; if meet duplicate characters then break; */
				}
			}
		}

		result = Math.Max(result, s.Length-p); /*s has no duplicate characteres*/
		return result;
	}
}