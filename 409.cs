/*
 409. Longest Palindrome

    Total Accepted: 14119
    Total Submissions: 32287
    Difficulty: Easy
    Contributors: Admin

Given a string which consists of lowercase or uppercase letters, find the length of the longest palindromes that can be built with those letters.

This is case sensitive, for example "Aa" is not considered a palindrome here.

Note:
Assume the length of given string will not exceed 1,010.

Example:

Input:
"abccccdd"

Output:
7

Explanation:
One longest palindrome that can be built is "dccaccd", whose length is 7.

*/
public class Solution {
	public int LongestPalindrome(string s) {
		if(s == null || s.Length == 0) {
			return 0;
		}

		int[] count = new int[256];
		//int odd to record single letter in the string
		int sum = 0, odd = 0;
		for(int i = 0; i < s.Length; i++) {
			sum++;
			if(count[s[i]] % 2 == 1) {
				odd--;
			}
			else {
				odd++;
			}

			count[s[i]]++;
		}

		return sum - Math.Max(0, odd - 1);
	}
}