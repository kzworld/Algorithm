/* 304. Range Sum Query 2D - Immutable    Difficulty: Medium
Given a 2D matrix matrix, find the sum of the elements inside the rectangle defined by its upper left corner (row1, col1) and lower right corner (row2, col2).
  [2, 0, 1]
  [1, 0, 1]
  [0, 3, 0]
Range Sum Query 2D
The above rectangle (with the red border) is defined by (row1, col1) = (2, 1) and (row2, col2) = (4, 3), which contains sum = 8.

Example:

Given matrix = [
  [3, 0, 1, 4, 2],
  [5, 6, 3, 2, 1],
  [1, 2, 0, 1, 5],
  [4, 1, 0, 1, 7],
  [1, 0, 3, 0, 5]
]

sumRegion(2, 1, 4, 3) -> 8
sumRegion(1, 1, 2, 2) -> 11
sumRegion(1, 2, 2, 4) -> 12
*/

public class NumMatrix {
	private int[, ] sums = null;
	private int rows = 0;
	private int cols = 0;
	public NumMatrix(int[, ] matrix)
	{
		this.rows = matrix.GetLength(0);
		this.cols = matrix.GetLength(1);
		this.sums = new int[this.rows, this.cols];
		for (int r = rows - 1; r >= 0; r--)
		{
			int sum = 0;
			for (int c = cols - 1; c >= 0; c--)
			{
				sum += matrix[r, c];
				this.sums[r, c] = sum;
			}
		}
	}
	public int SumRegion(int row1, int col1, int row2, int col2)
	{
		int sum = 0;
		int endCol = col2 + 1 < this.cols ? col2 + 1 : -1;
		for (int r = row1; r <= row2; r++)
		{
			sum += this.sums[r, col1] - (endCol > 0 ? this.sums[r, endCol] : 0);
		}
		return sum;
	}
}
// Your NumMatrix object will be instantiated and called as such:
// NumMatrix numMatrix = new NumMatrix(matrix);
// numMatrix.SumRegion(0, 1, 2, 3);
// numMatrix.SumRegion(1, 2, 3, 4);








/*
Construct a 2D array sums[row+1][col+1]

(notice: we add additional blank row sums[0][col+1]={0} and blank column sums[row+1][0]={0} to remove the edge case checking), so, we can have the following definition

sums[i+1][j+1] represents the sum of area from matrix[0][0] to matrix[i][j]

To calculate sums, the ideas as below

+-----+-+-------+ +--------+-----+ +-----+---------+ +-----+--------+
|     | |       | |        |     | |     |         | |     |        |
|     | |       | |        |     | |     |         | |     |        |
+-----+-+       | +--------+     | |     |         | +-----+        |
|     | |       |=|              |+|     |         |-|              |
+-----+-+       | |              | +-----+         | |              |
|               | |              | |               | |              |
|               | |              | |               | |              |
+---------------+ +--------------+ +---------------+ +--------------+

   sums[i][j]      =    sums[i-1][j]    +     sums[i][j-1]    -   sums[i-1][j-1]   +  

                        matrix[i-1][j-1]

So, we use the same idea to find the specific area's sum.

+---------------+  +--------------+   +---------------+  +--------------+ +--------------+
|               |  |         |    |   |   |           |  |         |    | |   |          |
|   (r1,c1)     |  |         |    |   |   |           |  |         |    | |   |          |
|   +------+    |  |         |    |   |   |           |  +---------+    | +---+          |
|   |      |    |= |         |    | - |   |           |- |      (r1,c2) |+|   (r1,c1)    |
|   |      |    |  |         |    |   |   |           |  |              | |              |
|   +------+    |  +---------+    |   +---+           |  |              | |              |
|        (r2,c2)|  |       (r2,c2)|   |   (r2,c1)     |  |              | |              |
+---------------+  +--------------+   +---------------+  +--------------+ +--------------+

And we can have the following code
*/