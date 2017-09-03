/* 42. Trapping Rain Water

    Total Accepted: 90093
    Total Submissions: 258356
    Difficulty: Hard
    Contributors: Admin

Given n non-negative integers representing an elevation map where the width of each bar is 1, compute how much water it is able to trap after raining.

For example,
Given [0,1,0,2,1,0,1,3,2,1,2,1], return 6.


The above elevation map is represented by array [0,1,0,2,1,0,1,3,2,1,2,1]. In this case, 6 units of rain water (blue section) are being trapped. Thanks Marcos for contributing this image!*/
public class Solution {
	private int res, right = 1, left, curx, limit;
	public int Trap(int[] height) {
		while(right<height.Length)
		{
			if(height[right]>= height[left])
			{
				res+= curx;
				left = right++;
				curx = 0;
			}
			else
			{
				curx+= height[left]-height[right++];
			}
		}

		if(curx>0)
		{
			curx = 0;
			limit = left;
			left =--right;
			while(limit<right)
			{
				if(height[left]>= height[right])
				{
					res+= curx;
					right = left--;
					curx = 0;
				}
				else
				{
					curx+= height[right]-height[left--];
				}
			}
		}

		return res;
	}
}