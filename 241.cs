/*
241. Different Ways to Add Parentheses
Given a string of numbers and operators, return all possible results from computing all the different possible ways to group numbers and operators. The valid operators are +, - and *.

Example 1

Input: "2-1-1".

((2-1)-1) = 0
(2-(1-1)) = 2

Output: [0, 2]

Example 2

Input: "2*3-4*5"

(2*(3-(4*5))) = -34
((2*3)-(4*5)) = -14
((2*(3-4))*5) = -10
(2*((3-4)*5)) = -10
(((2*3)-4)*5) = 10

Output: [-34, -14, -10, -10, 10]
*/
public class Solution {
	public IList<int> DiffWaysToCompute(string input) {
		if (string.IsNullOrWhiteSpace(input)) return null;
		var result = new List<int>();

		for (int i = 1; i < input.Length - 1; i++)
		{
			if (input[i] == '+' || input[i] == '*' || input[i] == '-')
			{
				var left = input.Substring(0, i);
				var right = input.Substring(i + 1);
				foreach (var l in DiffWaysToCompute(left))
				{
					foreach (var r in DiffWaysToCompute(right))
					{
						switch (input[i])
						{
							case '+':
                                result.Add(l + r);
							break;
							case '*':
                                result.Add(l * r);
							break;
							case '-':
                                result.Add(l - r);
							break;
						}
					}
				}
			}
		}

		if(!result.Any()) result.Add(int.Parse(input));
		return result;
	}
}