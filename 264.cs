/*264. Ugly Number II

    Total Accepted: 39820
    Total Submissions: 131391
    Difficulty: Medium

Write a program to find the n-th ugly number.

Ugly numbers are positive numbers whose prime factors only include 2, 3, 5. For example, 1, 2, 3, 4, 5, 6, 8, 9, 10, 12 is the sequence of the first 10 ugly numbers.

Note that 1 is typically treated as an ugly number. */

public class Solution {
	public int NthUglyNumber(int n) {
		int t2 = 0, t3 = 0, t5 = 0, factor2 = 2, factor3 = 3, factor5 = 5;
		int[] ugly = new int[n];
		ugly[0] = 1;
		for(int i = 1;i<n;i++)
		{
			int min = Math.Min(Math.Min(factor2, factor3), factor5);
			ugly[i] = min;
			if(factor2 == min) factor2 = 2*ugly[++t2];
			if(factor3 == min) factor3 = 3*ugly[++t3];
			if(factor5 == min) factor5 = 5*ugly[++t5];
		}

		return ugly[n-1];
	}
}