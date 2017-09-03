/*343. Integer Break

    Total Accepted: 24071
    Total Submissions: 55592
    Difficulty: Medium

Given a positive integer n, break it into the sum of at least two positive integers and maximize the product of those integers. Return the maximum product you can get.

For example, given n = 2, return 1 (2 = 1 + 1); given n = 10, return 36 (10 = 3 + 3 + 4).

Note: You may assume that n is not less than 2 and not larger than 58. */

public class Solution {
	public int IntegerBreak(int n) {
		if(n == 2) return 1;
		if(n == 3) return 2;
		if(n == 4) return 4;
		if(n%3 == 0) return (int)Math.Pow(3, n/3);
		/*if n%3 ==1 means last divide number is 4,*/
		if(n%3 == 1) return (int)Math.Pow(3, (n-4)/3)*4;
		return (int)Math.Pow(3, n/3)*(n%3);
	}
}