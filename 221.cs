/*
 221. Maximal Square     Difficulty: Medium


Given a 2D binary matrix filled with 0's and 1's, find the largest square containing only 1's and return its area.

For example, given the following matrix:

1 0 1 0 0
1 0 1 1 1
1 1 1 1 1
1 0 0 1 0

Return 4. 
*/

public class Solution {
	public int MaximalSquare(char[, ] matrix) {
		int max = 0;
		int[, ] dp = new int[matrix.GetLength(0) + 1, matrix.GetLength(1) + 1];

		for(int i = 1; i <= matrix.GetLength(0); ++i) {
			for(int j = 1; j <= matrix.GetLength(1); ++j) {
				if (matrix[i-1, j-1] == '1') {
				
				dp[i, j] = 
					Math.Min(
							dp[i-1, j], 
							Math.Min(dp[i, j-1], dp[i-1, j-1])
							) + 1;
					
					max = Math.Max(dp[i, j], max);
				}
			}
		}

		return max * max;
	}
}
/*
In coming up with this DP solution, one needs to understand what dp[i,j] should represent. Should it represent the best solution for the board at i-1,j-1? No, that approach won't work because it doesn't tell us how to dynamically obtain the size of a square in the first place. It needs to represent the best area for a square ending at i-1, j-1. How to tell whether a square can be made from a given position? Check the left, top left and top cells in the DP that we are calculating. If they are all equal, a greater square can be made, otherwise degrade to the minimum size. We use dp of 1 size greater so that the DP step works without boundary checks.
*/