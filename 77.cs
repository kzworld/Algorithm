/*77. Combinations

    Total Accepted: 89638 Total Submissions: 245136 Difficulty: Medium 

Given two integers n and k, return all possible combinations of k numbers out of 1 ... n.

For example,
If n = 4 and k = 2, a solution is:

[
  [2,4],
  [3,4],
  [2,3],
  [1,2],
  [1,3],
  [1,4],
]
*/
public class Solution {
	public IList<IList<int>> Combine(int n, int k) {
		IList<IList<int>> result = new List<IList<int>> ();
		if(n <= 0 || k <= 0 || n < k)			return result;
		int[] nums = new int[n];
		for(int i = 0; i < n; i++)			nums[i] = i+1;
		int[] combination = new int[k];
		doCombine(nums, combination, 0, 0, n, k, result);
		return result;
	}

	public void doCombine(int[] nums, int[] combination, int level, int startIndex, int n, int k, IList<IList<int>> result) {
		if(level == k) {
			List<int> combinationList = new List<int>();
			for(int i = 0; i < k; i++) combinationList.Add(combination[i]);			
			result.Add(combinationList);
			return;
		}

		for(int i = startIndex; i <= (n-k+level); i++) {
			combination[level] = nums[i];
			doCombine(nums, combination, level+1, i+1, n, k, result);
		}
	}
}