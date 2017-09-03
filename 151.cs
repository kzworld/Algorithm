/*151. Reverse Words in a String               Medium

Given an input string, reverse the string word by word.

For example,
Given s = "the sky is blue",
return "blue is sky the".
 */

public class Solution {
	public string ReverseWords(string s) {
		string[] strs = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
		string[] result = new string[strs.Length];

		int count = 0;
		int i = strs.Length-1;
		while(i>= 0)
		{
			result[count++]	 = strs[i--];
		}

		return String.Join(" ", result);
	}
}