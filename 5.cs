/*5. Longest Palindromic Substring

    Total Accepted: 127483
    Total Submissions: 535734
    Difficulty: Medium

Given a string S, find the longest palindromic substring in S. 
You may assume that the maximum length of S is 1000, and there exists one unique longest palindromic substring.*/
public class Solution {
	public string LongestPalindrome(string s) {
		if (s.Length == 1) return s;
		int min_start = 0, max_len = 1;
		for (int i = 0; i < s.Length;) {
			if (s.Length - i <= max_len / 2) break;
			int j = i, k = i;
			while (k < s.Length-1 && s[k+1] == s[k]) ++k; // Skip duplicate characters.
      i = k+1;
			while (k < s.Length-1 && j > 0 && s[k + 1] == s[j - 1]) { ++k; --j; } // Expand.
      int new_len = k - j + 1;
			if (new_len > max_len) { min_start = j; max_len = new_len; }
		}

		return s.Substring(min_start, max_len);
	}
}