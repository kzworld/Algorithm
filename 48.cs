/* 48. Rotate Image

    Total Accepted: 86336
    Total Submissions: 236132
    Difficulty: Medium
    Contributors: Admin

You are given an n x n 2D matrix representing an image.

Rotate the image by 90 degrees (clockwise).

Follow up:
Could you do this in-place?*/

public class Solution {
	public void Rotate(int[, ] matrix) {
		int n = matrix.GetLength(0);
		int looptime = (n+1)/2;
		for(int x = 0;x<looptime;x++)
		{
			for(int y = x;y<n-1-x;y++)
			{
				int tmp = matrix[x, y];
				matrix[x, y] = matrix[n-1-y, x];
				matrix[n-1-y, x] = matrix[n-1-x, n-1-y];
				matrix[n-1-x, n-1-y] = matrix[y, n-1-x];
				matrix[y, n-1-x] = tmp;
			}
		}
	}
}