/*300. Longest Increasing Subsequence

    Total Accepted: 43040
    Total Submissions: 119379
    Difficulty: Medium

Given an unsorted array of integers, find the length of longest increasing subsequence.

For example,
Given [10, 9, 2, 5, 3, 7, 101, 18],
The longest increasing subsequence is [2, 3, 7, 101], therefore the length is 4. Note that there may be more than one LIS combination, it is only necessary for you to return the length.

Your algorithm should run in O(n2) complexity.

Follow up: Could you improve it to O(n log n) time complexity? */
public class Solution {
	public int LengthOfLIS(int[] nums) {
		if (nums.Length<1) return 0;
		int max = 0;
		int[] F = new int[nums.Length];
		for(int i = 0;i<nums.Length;i++)
		{
			F[i] = 1;
		}

		for(int i = 0;i<nums.Length;i++)
		{
			for(int j = 0;j<i;j++)
			{
				if(nums[i]>nums[j]&&F[j]+1>F[i]) F[i]++;
			}

			if(max<F[i]) max = F[i];

			Console.WriteLine(nums[i]+"  "+F[i]);
		}

		return max;
	}
}