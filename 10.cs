/*10. Regular Expression Matching

    Total Accepted: 94886
    Total Submissions: 415898
    Difficulty: Hard

Implement regular expression matching with support for '.' and '*'.

'.' Matches any single character.
'*' Matches zero or more of the preceding element.

The matching should cover the entire input string (not partial).

The function prototype should be:
bool isMatch(const char *s, const char *p)

Some examples:
isMatch("aa","a") → false
isMatch("aa","aa") → true
isMatch("aaa","aa") → false
isMatch("aa", "a*") → true
isMatch("aa", ".*") → true
isMatch("ab", ".*") → true
isMatch("aab", "c*a*b") → true
*/

public class Solution {
	public bool IsMatch(string s, string p) {
		if (s == null || p == null) {
			return false;
		}

		bool[, ] dp = new bool[s.Length+1, p.Length+1];
		dp[0, 0] = true;
		for (int i = 0; i < p.Length; i++) {
			if (p[i] == '*' && dp[0, i-1]) {
				dp[0, i+1] = true;
			}
		}

		for (int i = 0; i < s.Length; i++) {
			for (int j = 0; j < p.Length; j++) {
				if (p[j] == '.') {
					dp[i+1, j+1] = dp[i, j];
				}

				if (p[j] == s[i]) {
					dp[i+1, j+1] = dp[i, j];
				}

				if (p[j] == '*') {
					if (p[j-1] != s[i] && p[j-1] != '.') {
						dp[i+1, j+1] = dp[i+1, j-1];
					}					else {
						dp[i+1, j+1] = (dp[i+1, j] || dp[i, j+1] || dp[i+1, j-1]);
					}
				}
			}
		}

		return dp[s.Length, p.Length];
	}
}