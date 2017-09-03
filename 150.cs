/*
 150. Evaluate Reverse Polish Notation

    Total Accepted: 78202
    Total Submissions: 307469
    Difficulty: Medium
    Contributors: Admin

Evaluate the value of an arithmetic expression in Reverse Polish Notation.

Valid operators are +, -, *, /. Each operand may be an integer or another expression.

Some examples:

  ["2", "1", "+", "3", "*"] -> ((2 + 1) * 3) -> 9
  ["4", "13", "5", "/", "+"] -> (4 + (13 / 5)) -> 6

*/
public class Solution {
	public int EvalRPN(string[] tokens) {
		Stack<int> stack = new Stack<int>();

		for (int i = 0; i < tokens.Length; i++) {
			switch (tokens[i]) {
				case "+":
        stack.Push(stack.Pop() + stack.Pop());
				break;

				case "-":
        stack.Push(-stack.Pop() + stack.Pop());
				break;

				case "*":
        stack.Push(stack.Pop() * stack.Pop());
				break;

				case "/":
        int n1 = stack.Pop(), n2 = stack.Pop();
				stack.Push(n2 / n1);
				break;

				default:
        stack.Push(int.Parse(tokens[i]));
				break;
			}
		}

		return stack.Pop();
	}
}