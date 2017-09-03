/*50. Pow(x, n)

    Total Accepted: 105493
    Total Submissions: 382945
    Difficulty: Medium

Implement pow(x, n). */
public class Solution {
	public double MyPow(double x, int n) {
		if(n == 0)
			return 1;
		if(n < 0) {
			if(n == int.MinValue)
				return 1.0/ (MyPow(x, int.MaxValue) * x);
			else
				return 1.0/MyPow(x, -n);
		}

		return (n%2 == 0) ? MyPow(x*x, n/2) : x*MyPow(x*x, n/2);
	}
}