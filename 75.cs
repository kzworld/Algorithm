/*75. Sort Colors

    Total Accepted: 113757
    Total Submissions: 318450
    Difficulty: Medium

Given an array with n objects colored red, white or blue, sort them so that objects of the same color are adjacent, with the colors in the order red, white and blue.

Here, we will use the integers 0, 1, and 2 to represent the color red, white, and blue respectively. */

public class Solution {
	public void SortColors(int[] nums) {
		if (nums.Length<1) return;
		for(int pass = 0;pass<nums.Length;pass++)
		{
			for(int i = 0;i<nums.Length-1;i++)
				if(nums[i]>nums[i+1])
				{
					swap(i, i+1, nums);
				}
			}
		}

	public void swap(int i, int j, int[] nums)
	{
		int temp = nums[i];
		nums[i] = nums[j];
		nums[j] = temp;
	}
}