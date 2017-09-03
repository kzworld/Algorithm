/*
 89. Gray Code

    Total Accepted: 74711
    Total Submissions: 192648
    Difficulty: Medium
    Contributors: Admin

The gray code is a binary numeral system where two successive values differ in only one bit.

Given a non-negative integer n representing the total number of bits in the code, print the sequence of gray code. A gray code sequence must begin with 0.

For example, given n = 2, return [0,1,3,2]. Its gray code sequence is:

00 - 0
01 - 1
11 - 3
10 - 2

Note:
For a given n, a gray code sequence is not uniquely defined.

For example, [0,2,3,1] is also a valid gray code sequence according to the above definition.

For now, the judge is able to judge based on one instance of gray code sequence. Sorry about that.
*/
public class Solution {
	public IList<int> GrayCode(int n) {
		List<int> r = new List<int>();
		r.Add(0);
		int mask = 0x1;
		for(int i = 1; i<= n; i++)
		{
			int len = r.Count;
			for(int j = len-1; j>= 0; j--)
			{
				int v = mask|r[j];
				r.Add(v);
			}

			mask = mask<<1;
		}

		return r;
	}
}