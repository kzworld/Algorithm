/*
 368. Largest Divisible Subset

    Total Accepted: 14241
    Total Submissions: 44014
    Difficulty: Medium
    Contributors: Admin

Given a set of distinct positive integers, find the largest subset such that every pair (Si, Sj) of elements in this subset satisfies: Si % Sj = 0 or Sj % Si = 0.

If there are multiple solutions, return any subset is fine.

Example 1:

nums: [1,2,3]

Result: [1,2] (of course, [1,3] will also be ok)

Example 2:

nums: [1,2,4,8]

Result: [1,2,4,8]

Credits:
Special thanks to @Stomach_ache for adding this problem and creating all test cases.
*/
public class Solution {
	public IList<int> LargestDivisibleSubset(int[] nums) {
		if(nums.Length == 0) return new List<int>();
		var list = new List<int>();

		Array.Sort(nums);
		var depths = new int[nums.Length];
		int maxDepth = 0, maxI = 0;

		for(int i = 1; i < nums.Length; i++) {
			var max = -1;
			for(int j = 0; j < i; j++) {
				if(nums[i] % nums[j] == 0)
					max = Math.Max(max, depths[j]);
			}

			depths[i] = ++max;
			if(max > maxDepth) {
				maxDepth = max;
				maxI = i;
			}
		}

		list.Add(nums[maxI]);
		for(int i = maxI - 1; i > -1; i--) {
			if(nums[maxI] % nums[i] != 0 || depths[i] + 1 != maxDepth)
				continue;

			list.Add(nums[i]);
			maxDepth--;
			maxI = i;
		}

		return list;
	}
}