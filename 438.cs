/*438. Find All Anagrams in a String
Description Submission Solutions

    Total Accepted: 19912
    Total Submissions: 59625
    Difficulty: Easy
    Contributors: Stomach_ache

Given a string s and a non-empty string p, find all the start indices of p's anagrams in s.

Strings consists of lowercase English letters only and the length of both strings s and p will not be larger than 20,100.

The order of output does not matter.

Example 1:

Input:
s: "cbaebabacd" p: "abc"

Output:
[0, 6]

Explanation:
The substring with start index = 0 is "cba", which is an anagram of "abc".
The substring with start index = 6 is "bac", which is an anagram of "abc".

Example 2:

Input:
s: "abab" p: "ab"

Output:
[0, 1, 2]

Explanation:
The substring with start index = 0 is "ab", which is an anagram of "ab".
The substring with start index = 1 is "ba", which is an anagram of "ab".
The substring with start index = 2 is "ab", which is an anagram of "ab".
*/
public class Solution {
    public IList<int> FindAnagrams(string s, string p) {
        List<int> res = new List<int>();
        if(string.IsNullOrEmpty(s) || string.IsNullOrEmpty(p)) {
            return res;
        }
        int len1 = s.Length, len2 = p.Length;
        if(len2 > len1) return res;
        int[] anagram = new int[256];

        for(int i = 0; i < len2; i++) {
            anagram[s[i]]++;
            anagram[p[i]]--;
        }
        int diff = 0;
        foreach (int i in anagram) {
            if(i != 0) diff++;
        }
        for(int i = len2; i < len1; i++) {
            if(diff == 0) res.Add(i - len2);
            char c1 = s[i];
            char c2 = s[i - len2];
            if(c1 == c2) continue;
            
            anagram[c1]++;
            anagram[c2]--;
            if(anagram[c1] == 1) diff++;
            else if(anagram[c1] == 0) diff--;
            
            if(anagram[c2] == -1) diff++;
            else if(anagram[c2] == 0) diff--;
        }
        if(diff == 0) {
            res.Add(len1 - len2);
        }
        return res;
    }
}