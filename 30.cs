/*
30. Substring with Concatenation of All Words

    Total Accepted: 62485
    Total Submissions: 292675
    Difficulty: Hard

You are given a string, s, and a list of words, words, that are all of the same length. Find all starting indices of substring(s) in s that is a concatenation of each word in words exactly once and without any intervening characters.

For example, given:
s: "barfoothefoobarman"
words: ["foo", "bar"]

You should return the indices: [0,9].
(order does not matter). 
*/
public class Solution {
	public IList<int> FindSubstring(string s, string[] words)
	{
		List<int> list = new List<int>();
		if(String.IsNullOrEmpty(s) || words == null || words.Length == 0) return list;

		Dictionary<string, int> dict = new Dictionary<string, int>();
		foreach(string w in words)
		{
			if(!dict.ContainsKey(w)) dict[w] = 1;
			else dict[w]++;
		}

		Dictionary<string, int> savedDict = new Dictionary<string, int>(dict);
		int wLen = words[0].Length;
		for(int i = 0; i <= s.Length - words.Length * wLen; i++)
		{
			int j = 0;
			for(; j < words.Length; j++)
			{
				string w = s.Substring(i + j * wLen, wLen);

				if(!dict.ContainsKey(w)) break;
				else if(--dict[w] < 0) break;
			}

			if(j == words.Length) list.Add(i);

			dict = new Dictionary<string, int>(savedDict);
		}

		return list;
	}
}