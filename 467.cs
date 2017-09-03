/*
467. Unique Substrings in Wraparound String
Consider the string s to be the infinite wraparound string of "abcdefghijklmnopqrstuvwxyz", so s will look like this: "...zabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcd....".

Now we have another string p. Your job is to find out how many unique non-empty substrings of p are present in s. In particular, your input is the string p and you need to output the number of different non-empty substrings of p in the string s.

Note: p consists of only lowercase English letters and the size of p might be over 10000.

Example 1:

Input: "a"
Output: 1

Explanation: Only the substring "a" of string "a" is in the string s.



Example 2:

Input: "cac"
Output: 2
Explanation: There are two substrings "a", "c" of string "cac" in the string s.



Example 3:

Input: "zab"
Output: 6
Explanation: There are six substrings "z", "a", "b", "za", "ab", "zab" of string "zab" in the string s.


*/
//C#
public class Solution {
	public int FindSubstringInWraproundString(string p) {
			
		int[] cnt = new int[26];
		int res = 0, len = 0;
		for (int i = 0; i < p.Length; ++i) {
			int cur = p[i] - chr('a');
			if (i > 0 && p[i - 1] != (cur + 26 - 1) % 26 + 'a')
					len = 0;
            if (++len > cnt[cur]) {
                res += len - cnt[cur];
                cnt[cur] = len;
            }
        }
        return res;
    }
}
 //Python 
class Solution(object):
    def findSubstringInWraproundString(self, p):
        """
        :type p: str
        :rtype: int
        """      
        pattern = 'zabcdefghijklmnopqrstuvwxyz'
        cmap = collections.defaultdict(int)
        clen = 0
        for c in range(len(p)):
            if c and p[c-1:c+1] not in pattern:
                clen = 1
            else:
                clen += 1
            cmap[p[c]] = max(clen, cmap[p[c]])
        return sum(cmap.values())