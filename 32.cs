/*32. Longest Valid Parentheses

    Total Accepted: 72045
    Total Submissions: 316102
    Difficulty: Hard

Given a string containing just the characters '(' and ')', find the length of the longest valid (well-formed) parentheses substring.

For "(()", the longest valid parentheses substring is "()", which has length = 2.

Another example is ")()())", where the longest valid parentheses substring is "()()", which has length = 4.

Subscribe to see which companies asked this question
*/
public class Solution {
	public int LongestValidParentheses(string s) {
		Stack<int> stack = new Stack<int>();
		int max = 0;
		int left = -1;
		for(int j = 0;j<s.Length;j++) {
			if(s[j] == '(') stack.Push(j);
			else {
				if (stack.Count == 0) left = j;
				else {
					stack.Pop();
					if(stack.Count == 0) max = Math.Max(max, j-left);
					else max = Math.Max(max, j-stack.Peek());
				}
			}
		}

		return max;
	}
}