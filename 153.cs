/*153. Find Minimum in Rotated Sorted Array

    Total Accepted: 108131
    Total Submissions: 288125
    Difficulty: Medium

Suppose a sorted array is rotated at some pivot unknown to you beforehand.

(i.e., 0 1 2 4 5 6 7 might become 4 5 6 7 0 1 2).

Find the minimum element.

You may assume no duplicate exists in the array.*/
public class Solution {
	public int FindMin(int[] nums) {
		int start = 0;
		while(start<nums.Length-1)
		{
			if(nums[start]<nums[nums.Length-1]) return nums[start];
			start++;
		}

		return nums[start];
	}
}