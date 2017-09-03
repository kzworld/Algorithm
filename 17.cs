/*17. Letter Combinations of a Phone Number

    Total Accepted: 95999
    Total Submissions: 315212
    Difficulty: Medium

Given a digit string, return all possible letter combinations that the number could represent.

A mapping of digit to letters (just like on the telephone buttons) is given below.

Input:Digit string "23"
Output: ["ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"].

Note:
Although the above answer is in lexicographical order, your answer could be in any order you want. */
public class Solution {
	//Set Keys 1-9
	private static string[] KEYS = { "", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
	private IList<string> ret = new List<String>();
	public IList<string> LetterCombinations(string digits) {
		if(digits == null || digits.Length == 0) return ret;
		combination("", digits, 0);
		return ret;
	}



	private void combination(string prefix, string digits, int offset) {
		if (offset == digits.Length) {
			ret.Add(prefix);
			return;
		}


		string letters = KEYS[(digits[offset] - '0')];
		for (int i = 0; i < letters.Length; i++) {
			combination(prefix + letters[i], digits, offset + 1);
		}
	}
}