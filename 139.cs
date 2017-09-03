/*
 139. Word Break
Description Submission Solutions

    Total Accepted: 133366
    Total Submissions: 462826
    Difficulty: Medium
    Contributors: Admin

Given a non-empty string s and a dictionary wordDict containing a list of non-empty words, determine if s can be segmented into a space-separated sequence of one or more dictionary words. You may assume the dictionary does not contain duplicate words.

For example, given
s = "leetcode",
dict = ["leet", "code"].

Return true because "leetcode" can be segmented as "leet code". 
*/

public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) {
         
        bool[] f = new bool[s.Length + 1];
        f[0] = true;
        for(int i=1; i <= s.Length; i++){
            for(int j=0; j < i; j++){
                if(f[j] && wordDict.Contains(s.Substring(j, i-j))){
                    f[i] = true;
                    break;
                }
            }
        }        
        return f[s.Length];
    }
}