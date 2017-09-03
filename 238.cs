/*238. Product of Array Except Self

    Total Accepted: 59595
    Total Submissions: 132666
    Difficulty: Medium

Given an array of n integers where n > 1, nums, return an array output such that output[i] is equal to the product of all the elements of nums except nums[i].

Solve it without division and in O(n).

For example, given [1,2,3,4], return [24,12,8,6]. */
public class Solution {
	public int[] ProductExceptSelf(int[] nums) {
		int[] result = new int[nums.Length];
		result[result.Length-1] = 1;

		for(int i = nums.Length-2; i>= 0; i--) {
			result[i] = result[i+1] * nums[i+1];
		}

		int left = 1;
		for(int i = 0; i<nums.Length; i++) {
			result[i] *= left;
			left *= nums[i];
		}

		return result;
	}
}