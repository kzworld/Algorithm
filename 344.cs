/*344. Reverse String

    Total Accepted: 80498
    Total Submissions: 137955
    Difficulty: Easy

Write a function that takes a string as input and returns the string reversed.

Example:
Given s = "hello", return "olleh". 
*/
public class Solution {
	public string ReverseString(string s) {
		Stack<char> stack = new Stack<char>(s);
		char[] res = new char[s.Length];
		int i = 0;
		while(stack.Count>0)
		{
			res[i++] = stack.Pop();
		}

		/*LIFO */
		return new string(res);
	}
}