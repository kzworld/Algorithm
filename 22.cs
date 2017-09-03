/*22. Generate Parentheses

    Total Accepted: 103113
    Total Submissions: 262414
    Difficulty: Medium

Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.

For example, given n = 3, a solution set is:		

[
  "((()))",
  "(()())",
  "(())()",
  "()(())",
  "()()()"
]
*/
public class Solution {
	private void helper(IList<string> res, string present, int left, int right) {
		if (right == 0) {
			res.Add(present);
		}

		if (left > 0) {
			helper(res, present + "(", left - 1, right);
		}

		if (right > left) {
			helper(res, present + ")", left, right - 1);
		}
	}

	public IList<string> GenerateParenthesis(int n) {
		IList<string> res = new List<string>();
		if (n == 0) {
			return res;
		}

		helper(res, "", n, n);
		return res;
	}
}