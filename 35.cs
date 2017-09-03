/*35. Search Insert Position

    Total Accepted: 121111
    Total Submissions: 316582
    Difficulty: Medium

Given a sorted array and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.

You may assume no duplicates in the array.

Here are few examples.
[1,3,5,6], 5 → 2
[1,3,5,6], 2 → 1
[1,3,5,6], 7 → 4
[1,3,5,6], 0 → 0 */
public class Solution {
	public int SearchInsert(int[] nums, int target) {
		int left = 0, right = nums.Length - 1;

		while (left <= right) {
			int mid = left + ((right - left) >> 1); /*x>>1   means x/2      x>>2 means x/4    x<<1 means x*2   x<<2 means x*4 ....*/

			if (nums[mid] == target)
				return mid;
			else if (nums[mid] > target)
				right = mid - 1;
			else
				left = mid + 1;
		}

		return left;

		/** 
         * Explanation: 
         * 1. If the insert position is at the most left, 
         *      e.g. [2,3,5,6] , target = 1. When the loop ends, left = 0, right = -1.
         * 
         * 2. If the insert position is at the most right,
         *      e.g. [2,3,5,6] , target = 7. When the loop ends, left = 4, right = 3.
         * 
         * 3. If insert in the middle,
         *      e.g. [2,3,5,6] , target = 4. When the loop ends, left = 2, right = 1.
         * 
         * ***/
	}
}