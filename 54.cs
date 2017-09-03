/*54. Spiral Matrix

    Total Accepted: 70162
    Total Submissions: 297199
    Difficulty: Medium

Given a matrix of m x n elements (m rows, n columns), return all elements of the matrix in spiral order.

For example,
Given the following matrix:

[
 [ 1, 2, 3 ],
 [ 4, 5, 6 ],
 [ 7, 8, 9 ]
]

You should return [1,2,3,6,9,8,7,4,5]. */

public class Solution {
	public IList<int> SpiralOrder(int[, ] matrix) {
		IList<int> res = new List<int>();

		if (matrix == null) {
			return res;
		}

		int rowBegin = 0;
		int rowEnd = matrix.GetLength(0) - 1;
		int colBegin = 0;
		int colEnd = matrix.GetLength(1) - 1;

		while (rowBegin <= rowEnd && colBegin <= colEnd) {
			// Traverse Right
            for (int j = colBegin; j <= colEnd; j ++) {
				res.Add(matrix[rowBegin, j]);
			}

			rowBegin++;

			// Traverse Down
            for (int j = rowBegin; j <= rowEnd; j ++) {
				res.Add(matrix[j, colEnd]);
			}

			colEnd--;

			if (rowBegin <= rowEnd) {
				// Traverse Left
                for (int j = colEnd; j >= colBegin; j --) {
					res.Add(matrix[rowEnd, j]);
				}
			}

			rowEnd--;

			if (colBegin <= colEnd) {
				// Traver Up
                for (int j = rowEnd; j >= rowBegin; j --) {
					res.Add(matrix[j, colBegin]);
				}
			}

			colBegin ++;
		}

		return res;
	}
}