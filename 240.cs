/*240. Search a 2D Matrix II

    Total Accepted: 47895
    Total Submissions: 131952
    Difficulty: Medium

Write an efficient algorithm that searches for a value in an m x n matrix. This matrix has the following properties:

    Integers in each row are sorted in ascending from left to right.
    Integers in each column are sorted in ascending from top to bottom.

For example,

Consider the following matrix:

[
  [1,   4,  7, 11, 15],
  [2,   5,  8, 12, 19],
  [3,   6,  9, 16, 22],
  [10, 13, 14, 17, 24],
  [18, 21, 23, 26, 30]
]

Given target = 5, return true.

Given target = 20, return false.
*/
public class Solution {
	public bool SearchMatrix(int[, ] matrix, int target) {
		int maxrow = matrix.GetLength(0)-1;
		int maxcol = matrix.GetLength(1)-1;
		int row = 0;
		int col = maxcol;

		while(col>= 0&&row<= maxrow)
		{
			//Console.WriteLine(row+"  "+col);
			if(target == matrix[row, col]) return true;
			else
				if(target>matrix[row, col]) { row++; }
			else
				if(target<matrix[row, col]) col--;
			// Console.WriteLine(row+"  "+col);
		}

		return false;
	}
}