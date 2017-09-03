/*
 81. Search in Rotated Sorted Array II

    Total Accepted: 76960
    Total Submissions: 235046
    Difficulty: Medium
    Contributors: Admin

Follow up for "Search in Rotated Sorted Array":
What if duplicates are allowed?

Would this affect the run-time complexity? How and why?

Write a function to determine if a given target is in the array.
*/
public class Solution {
	public bool Search(int[] nums, int target) {
		int start = 0, end = nums.Length;
		while (start < end) {
			int mid = (start + end) / 2;
			if (nums[mid] == target) return true;
			if (nums[mid] > nums[start]) { // nums[start..mid] is sorted
				// check if target in left half
                if (target < nums[mid] && target >= nums[start]) end = mid;
				else start = mid + 1;
			}			else if (nums[mid] < nums[start]) { // nums[mid..end] is sorted
				// check if target in right half
                if (target > nums[mid] && target < nums[start]) start = mid + 1;
				else end = mid;
			}			else { // have no idea about the array, but we can exclude nums[start] because nums[start] == nums[mid]
				start++;
			}
		}

		return false;
	}
}