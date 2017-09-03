/*64. Minimum Path Sum    Difficulty: Medium

Given a m x n grid filled with non-negative numbers, find a path from top left to bottom right which minimizes the sum of all numbers along its path.

Note: You can only move either down or right at any point in time.

*/

public class Solution {
    public int MinPathSum(int[,] grid) {
    int yaxis = grid.GetLength(0);// row
	int xaxis = grid.GetLength(1); // column
	for (int y = 0; y < yaxis; y++) 
	{
		for (int x = 0; x < xaxis; x++) 
		{
			if (y == 0 && x > 0) {
				grid[y,x] = grid[y,x] + grid[y,x-1];
			} else if (y > 0 && x == 0) {
				grid[y,x] = grid[y,x] + grid[y-1,x];
			} else if (y == 0 && x == 0) {
				grid[y,x] = grid[y,x];
			} else {
				grid[y,x] = Math.Min(grid[y,x - 1], grid[y - 1,x])
						+ grid[y,x];
			}
		}
	}

	return grid[yaxis - 1,xaxis - 1];
    }
}