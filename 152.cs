/*152. Maximum Product Subarray

    Total Accepted: 69850
    Total Submissions: 299396
    Difficulty: Medium

Find the contiguous subarray within an array (containing at least one number) which has the largest product.

For example, given the array [2,3,-2,4],
the contiguous subarray [2,3] has the largest product = 6. */

public class Solution {
	public int MaxProduct(int[] nums) {
		if(nums.Length == 0) return 0;
		int max = 0;
		int min = 0;
		int maxpre = 1;
		int minpre = 1;
		int maxsofar = nums[0];

		for(int i = 0;i<nums.Length;i++)
		{
			max = Math.Max(Math.Max(maxpre*nums[i], minpre*nums[i]), nums[i]);
			min = Math.Min(Math.Min(maxpre*nums[i], minpre*nums[i]), nums[i]);
			maxsofar = Math.Max(max, maxsofar);
			maxpre = max;
			minpre = min;
		}

		return maxsofar;
	}
}