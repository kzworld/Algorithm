/*74. Search a 2D Matrix

    Total Accepted: 91628
    Total Submissions: 262522
    Difficulty: Medium

Write an efficient algorithm that searches for a value in an m x n matrix. This matrix has the following properties:

    Integers in each row are sorted from left to right.
    The first integer of each row is greater than the last integer of the previous row.

For example,

Consider the following matrix:

[
  [1,   3,  5,  7],
  [10, 11, 16, 20],
  [23, 30, 34, 50]
]

Given target = 3, return true.*/
public class Solution {
	public bool SearchMatrix(int[, ] matrix, int target) {
		if(matrix.Length<1||matrix.GetLength(0)<1||matrix == null) return false;
		/*
        15
        Compare row top to bot
        if 1st element on this row > target   move down.
        */
        int maxrow = matrix.GetLength(0)-1;
		int maxcol = matrix.GetLength(1)-1;
		int row = maxrow;
		int col = 0;

		while(col<= maxcol&&row>= 0)
		{
			if(target == matrix[row, col]) return true;
			if(target>matrix[row, col]) col++;
			else
				if(target<matrix[row, col]) row--;
		}

		return false;
	}
}