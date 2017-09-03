/*268. Missing Number

    Total Accepted: 67568
    Total Submissions: 160950
    Difficulty: Medium

Given an array containing n distinct numbers taken from 0, 1, 2, ..., n, find the one that is missing from the array.

For example,
Given nums = [0, 1, 3] return 2.

Note:
Your algorithm should run in linear runtime complexity. Could you implement it using only constant extra space complexity? */
public class Solution {
	public int MissingNumber(int[] nums) {
		Array.Sort(nums);
		if (nums.Length == 0) return 0; /*null 1*/

        int result = 0;
		int count = 0;
		if (nums.Length!= 1) /*[0,1]*/
		{
			/*start count with 0, and plus 1 per time*/
			for (int i = 0;i<nums.Length;i++)
			{
				/*Find out the nums[i] that doesn't match with count, means missing value.*/
				if(nums[i]>= 0&&nums[i]!= count)
				{
					result = count;
					break;
				}

				if (i == nums.Length-1)
				{
					return nums[i]+1;
				}

				count++;
			}
		}
		else
		{
			result = nums[0]!= 0?0:nums[0]+1;
			/*
            0 return 1;
            
            2 return 0
            */
		}

		return result;
	}
}