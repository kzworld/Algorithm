/*34. Search for a Range

    Total Accepted: 97130
    Total Submissions: 323006
    Difficulty: Medium

Given a sorted array of integers, find the starting and ending position of a given target value.

Your algorithm's runtime complexity must be in the order of O(log n).

If the target is not found in the array, return [-1, -1].

For example,
Given [5, 7, 7, 8, 8, 10] and target value 8,
return [3, 4]. */
public class Solution {
	public int[] SearchRange(int[] nums, int target) {
		int count = 0;
		int pos = 0;

		for(int i = 0;i<nums.Length;i++)
		{
			if(nums[i] == target)
			{
				pos = i;
				/*count marks the duplicate times*/
				count++;
			}
		}
/*pos-count+1   mark the start position*/
		if(count>0) return new int[] { pos-count+1, pos };
		return new int[] { -1, -1 };
	}
}