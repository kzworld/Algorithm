/*43. Multiply Strings

    Total Accepted: 73366
    Total Submissions: 295378
    Difficulty: Medium

Given two numbers represented as strings, return multiplication of the numbers as a string.

Note:

    The numbers can be arbitrarily large and are non-negative.
    Converting the input string to integer is NOT allowed.
    You should NOT use internal library such as BigInteger.
*/

public class Solution {
	public string Multiply(string num1, string num2) {
		int m = num1.Length, n = num2.Length;
		int[] pos = new int[m + n];

		for(int i = m - 1; i >= 0; i--) {
			for(int j = n - 1; j >= 0; j--) {
				int mul = (num1[i] - '0') * (num2[j] - '0');
				int p1 = i + j, p2 = i + j + 1;
				int sum = mul + pos[p2];

				pos[p1] += sum / 10;
				pos[p2] = (sum) % 10;
			}
		}

		StringBuilder sb = new StringBuilder();
		foreach (int p in pos) if(!(sb.Length == 0 && p == 0)) sb.Append(p);
		return sb.Length == 0 ? "0" : sb.ToString();
	}
}

/*
Remember how we do multiplication?

Start from right to left, perform multiplication on every pair of digits, and add them together. Let's draw the process! From the following draft, we can immediately conclude:

 `num1[i] * num2[j]` will be placed at indices `[i + j`, `i + j + 1]` 
index 1				1	2	3	index i
index 0					4	5	index j
				_______________	
						1	5
					1	0
				0	5
					1	2
indices[1,2]	0	8			indices[i+j,i+j+1]
			0	4 
		_________________________
	index[	0,	1,	2,	3,	4]
	
			[p1,p2]
	<-----------------------
 
 
 
 
 
 
 
 
 
 
*/