/*33. Search in Rotated Sorted Array

    Total Accepted: 118428
    Total Submissions: 380273
    Difficulty: Hard

Suppose a sorted array is rotated at some pivot unknown to you beforehand.

(i.e., 0 1 2 4 5 6 7 might become 4 5 6 7 0 1 2).

You are given a target value to search. If found in the array return its index, otherwise return -1.

You may assume no duplicate exists in the array.*/
public class Solution {
	public int Search(int[] nums, int target) {
		if (nums == null) return -1;
		int lo = 0, hi = nums.Length-1;
		while (lo <= hi) {
			int mid = (hi-lo)/2 + lo;
			if (nums[mid] > target) {
				if (nums[lo] > nums[hi] && target <= nums[hi] && nums[mid] >= nums[lo]) {
					lo = mid + 1;
				}				else {
					hi = mid - 1;
				}
			}			else if (nums[mid] < target) {
				if (nums[lo] > nums[hi] && target >= nums[lo] && nums[mid] <= nums[hi]) {
					hi = mid - 1;
				}				else {
					lo = mid + 1;
				}
			}			else {
				return mid;
			}
		}

		return -1;
	}
}