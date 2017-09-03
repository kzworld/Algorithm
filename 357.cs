/*357. Count Numbers with Unique Digits

    Total Accepted: 14109
    Total Submissions: 32327
    Difficulty: Medium

Given a non-negative integer n, count all numbers with unique digits, x, where 0 ≤ x < 10^n.

Example:
Given n = 2, return 91. (The answer should be the total numbers in the range of 0 ≤ x < 100, excluding [11,22,33,44,55,66,77,88,99]) */

public class Solution {
	public int CountNumbersWithUniqueDigits(int n) {
		if (n == 0) return 1;
		if (n > 10) return CountNumbersWithUniqueDigits(10);
		int result = 0;
		for (int i = 1; i <= n; i++) {
			result += help(i);
		}

		return result;
	}
/*
1		0
10		1 10个
100		2 每?0到?9 有1个不是 ex 11 22 ...			 100	-	(10-1)	
1000	3 每?00到?99 有2个不是 ex 11x 122 133 22? .... 		 1000	-	(10-1）×（10-2）    
*/
	private int help(int k) {
		int result = 9;
		if (k == 1) return 10;
		for (int i = 1; i < k; i++) {
			result *= (10 - i);
		}
//81
		return result;
	}
}