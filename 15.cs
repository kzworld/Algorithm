/*15. 3Sum

    Total Accepted: 139224
    Total Submissions: 701707
    Difficulty: Medium

Given an array S of n integers, are there elements a, b, c in S such that a + b + c = 0? Find all unique triplets in the array which gives the sum of zero.

Note: The solution set must not contain duplicate triplets.

For example, given array S = [-1, 0, 1, 2, -1, -4],

A solution set is:
[
  [-1, 0, 1],
  [-1, -1, 2]
]
*/
public class Solution {
	public IList<IList<int>> ThreeSum(int[] nums) {
		Array.Sort(nums);
		IList<IList<int>> result = new List<IList<int>>();

		if(nums.Length < 3) return result;

		int i = 0;
		while(i < nums.Length - 2) {
			if(nums[i] > 0) break;
			int j = i + 1;
			int k = nums.Length - 1;
			while(j < k) {
				int sum = nums[i] + nums[j] + nums[k];

				if(sum == 0) { IList<int> list = new List<int>();
					list.Add(nums[i]);
					list.Add(nums[j]);
					list.Add(nums[k]);
					result.Add(list); }
				if(sum <= 0) j++;
				if(sum >= 0) while(nums[k--] == nums[k] && j < k);
			}

			while(nums[i] == nums[++i] && i < nums.Length - 2);
		}

		return result;
	}
}