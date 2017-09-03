/*
45. Jump Game II

    Total Accepted: 74027
    Total Submissions: 286613
    Difficulty: Hard

Given an array of non-negative integers, you are initially positioned at the first index of the array.

Each element in the array represents your maximum jump length at that position.

Your goal is to reach the last index in the minimum number of jumps.

For example:
Given array A = [2,3,1,1,4]

The minimum number of jumps to reach the last index is 2. (Jump 1 step from index 0 to 1, then 3 steps to the last index.)

Note:
You can assume that you can always reach the last index.

Subscribe to see which companies asked this question
*/
public class Solution {
	public int Jump(int[] nums)
	{
		if (nums.Length < 2) return 0;
		int begin = 0, end = 0, step = 0;
		while (true)
		{
			int max = 0;
			for (int i = begin; i <= end; i++)
				max = Math.Max(nums[i] + i, max);
			if (max <= end) return 0;
			if (max >= nums.Length - 1) return step + 1;
			begin = end + 1;
			end = max;
			step++;
		}
	}
}