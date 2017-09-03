/*29. Divide Two Integers

    Total Accepted: 76400
    Total Submissions: 479583
    Difficulty: Medium

Divide two integers without using multiplication, division and mod operator.

If it is overflow, return MAX_INT. */
public class Solution {
	public int Divide(int dividend, int divisor) {
		//Reduce the problem to positive long integer to make it easier.
		//Use long to avoid integer overflow cases.
	int sign = 1;
		if ((dividend > 0 && divisor < 0) || (dividend < 0 && divisor > 0))
			sign = -1;
		long ldividend = Math.Abs((long) dividend);
		long ldivisor = Math.Abs((long) divisor);

		//Take care the edge cases.
	if (ldivisor == 0) return int.MaxValue;
		if ((ldividend == 0) || (ldividend < ldivisor))	return 0;

		long lans = ldivide(ldividend, ldivisor);

		int ans;
		if (lans > int.MaxValue) { //Handle overflow.
		ans = (sign == 1)? int.MaxValue : int.MinValue;
		}		else {
			ans = (int) (sign * lans);
		}

		return ans;
	}

	private long ldivide(long ldividend, long ldivisor) {
		// Recursion exit condition
	if (ldividend < ldivisor) return 0;

		//  Find the largest multiple so that (divisor * multiple <= dividend), 
		//  whereas we are moving with stride 1, 2, 4, 8, 16...2^n for performance reason.
		//  Think this as a binary search.
	long sum = ldivisor;
		long multiple = 1;
		while ((sum+sum) <= ldividend) {
			sum += sum;
			multiple += multiple;
		}

		//Look for additional value for the multiple from the reminder (dividend - sum) recursively.
	return multiple + ldivide(ldividend - sum, ldivisor);
	}
}