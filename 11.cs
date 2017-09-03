/*11. Container With Most Water

    Total Accepted: 92245
    Total Submissions: 258866
    Difficulty: Medium

Given n non-negative integers a1, a2, ..., an, where each represents a point at coordinate (i, ai). n vertical lines are drawn such that the two endpoints of line i is at (i, ai) and (i, 0). Find two lines, which together with x-axis forms a container, such that the container contains the most water.

Note: You may not slant the container. 

*/

/*Analysis
  1 2 3 4 5 6
1 x ------- o
2 x x
3 x x x 
4 x x x x
5 x x x x x
6 x x x x x x

Next we move the left line and compute (2,6). Now if the right line is shorter, all cases below (2,6) are eliminated.

  1 2 3 4 5 6
1 x ------- o
2 x x       o
3 x x x     |
4 x x x x   |
5 x x x x x |
6 x x x x x x

And no matter how this o path goes, we end up only need to find the max value on this path, which contains n-1 cases.

  1 2 3 4 5 6
1 x ------- o
2 x x - o o o
3 x x x o | |
4 x x x x | |
5 x x x x x |
6 x x x x x x

*/

public class Solution
{
	public int MaxArea(int[] height)
	{
		if (height == null || height.Length < 2) {
			return 0;
		}


		int max = 0;
		int left = 0;
		int right = height.Length - 1;

		while (left < right) {
			max = Math.Max(max, (right - left) * Math.Min(height[left], height[right]));
			if (height[left] < height[right])
			left++;
			else
				right--;
		}



		return max;
	}
}