/*53. Maximum Subarray

    Total Accepted: 130700
    Total Submissions: 347970
    Difficulty: Medium

Find the contiguous subarray within an array (containing at least one number) which has the largest sum.

For example, given the array [-2,1,-3,4,-1,2,1,-5,4],
the contiguous subarray [4,-1,2,1] has the largest sum = 6. */

public class Solution {
	public int MaxSubArray(int[] nums) {
		int sum = nums[0];
		int tmp = 0;
		for (int i = 0;i<nums.Length;i++)
		{
			tmp = Math.Max(tmp+nums[i], nums[i]);

			sum = Math.Max(tmp, sum);
		}

		return sum;
	}
}