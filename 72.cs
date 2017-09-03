/* 72. Edit Distance

    Total Accepted: 72414
    Total Submissions: 239528
    Difficulty: Hard
    Contributors: Admin

Given two words word1 and word2, find the minimum number of steps required to convert word1 to word2. (each operation is counted as 1 step.)

You have the following 3 operations permitted on a word:

a) Insert a character
b) Delete a character
c) Replace a character*/
public class Solution
{
    private int[,] dp;

    public int MinDistance(string word1, string word2)
    {
        if (word1 == null || word2 == null)
        {
            return 0;
        }
        if (word1.Length == 0)
        {
            return word2.Length;
        }
        if (word2.Length == 0)
        {
            return word1.Length;
        }
        dp = new int[word1.Length, word2.Length];
        return calcDist(word1, word2, word1.Length - 1, word2.Length - 1);
    }

    public int calcDist(String word1, String word2, int i1, int i2)
    {
        if (i2 < 0 && i1 >= 0)
        {
            return i1 + 1; //Using +1 because the strings are zero-indexed;
        }
        if (i1 < 0 && i2 >= 0)
        {
            return i2 + 1;  //Using +1 because the strings are zero-indexed;
        }
        if (i2 < 0 && i1 < 0)
        {
            return 0;
        }
        if (dp[i1, i2] != 0)
        {
            return dp[i1, i2];
        }
        if (i1 >= 0 && i2 >= 0 && word1[i1] == word2[i2])
        {
            dp[i1, i2] = calcDist(word1, word2, i1 - 1, i2 - 1);
            return dp[i1, i2];
        }
        //Check which of the following is minimum: replace, insert or delete 
        int replace = 1 + calcDist(word1, word2, i1 - 1, i2 - 1);
        int insert = 1 + calcDist(word1, word2, i1, i2 - 1);
        int delete = 1 + calcDist(word1, word2, i1 - 1, i2);
        int min = Math.Min(delete, replace);
        min = Math.Min(min, insert);
        dp[i1, i2] = min;
        return min;
    }
}