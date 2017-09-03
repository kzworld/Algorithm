/*318. Maximum Product of Word Lengths

    Total Accepted: 31593
    Total Submissions: 77103
    Difficulty: Medium

Given a string array words, find the maximum value of length(word[i]) * length(word[j]) where the two words do not share common letters. You may assume that each word will contain only lower case letters. If no such two words exist, return 0.

Example 1:

Given ["abcw", "baz", "foo", "bar", "xtfn", "abcdef"]
Return 16
The two words can be "abcw", "xtfn".

Example 2:

Given ["a", "ab", "abc", "d", "cd", "bcd", "abcd"]
Return 4
The two words can be "ab", "cd".

Example 3:

Given ["a", "aa", "aaa", "aaaa"]
Return 0
No such pair of words.

Credits:
Special thanks to @dietpepsi for adding this problem and creating all test cases.*/

public class Solution {
	public int MaxProduct(string[] words) {
		int result = 0;
		for(int i = 0;i<words.Length-1;i++)
		{
			for(int z = i+1;z<words.Length;z++)
			{
				if(valid(words[i], words[z]))
				{
					int max = words[i].Length*words[z].Length;
					if(max>result)
					{
						result = max;
					}
				}
			}
		}

		return result;
	}

	private bool valid(string words, string wordspattern)
	{
		if(words.IndexOfAny(wordspattern.ToCharArray())!= -1) return false;

		return true;
	}
}