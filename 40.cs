/*
40. Combination Sum II

    Total Accepted: 82504
    Total Submissions: 279292
    Difficulty: Medium

Given a collection of candidate numbers (C) and a target number (T), find all unique combinations in C where the candidate numbers sums to T.

Each number in C may only be used once in the combination.

Note:

    All numbers (including target) will be positive integers.
    The solution set must not contain duplicate combinations.

For example, given candidate set [10, 1, 2, 7, 6, 1, 5] and target 8,
A solution set is:

[
  [1, 7],
  [1, 2, 5],
  [2, 6],
  [1, 1, 6]
]

*/

public class Solution {
	private IList<IList<int>> res = new List<IList<int>>();
	private IList<int> combination = new List<int>();
	public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
		Array.Sort(candidates);
		dfs(candidates, target, 0);
		return res;
	}

	private void dfs(int[] candidates, int target, int start)
	{
		if(target == 0)
		{
			res.Add(new List<int>(combination));
			return;
		}

		for(int i = start;i<candidates.Length;i++)
		{
			if(target < 0) return;
			if(i>start&&candidates[i] == candidates[i-1]) continue;
			combination.Add(candidates[i]);
			dfs(candidates, target-candidates[i], i+1);
			combination.Remove(candidates[i]);
		}
	}
}