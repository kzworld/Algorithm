/*39. Combination Sum

    Total Accepted: 111753 Total Submissions: 333675 Difficulty: Medium 

Given a set of candidate numbers (C) and a target number (T), find all unique combinations in C where the candidate numbers sums to T.

The same repeated number may be chosen from C unlimited number of times.

Note:x

    All numbers (including target) will be positive integers.
    The solution set must not contain duplicate combinations.

For example, given candidate set [2, 3, 6, 7] and target 7,
A solution set is:

[
  [7],
  [2, 2, 3]
]
*/
public class Solution {
	public List<IList<int>> result = new List<IList<int>>();
	public List<int> combination = new List<int>();
	public IList<IList<int>> CombinationSum(int[] candidates, int target)
	{
		Array.Sort(candidates);
		CombinationSum(candidates, target, 0);
		return result;
	}

	private void CombinationSum(int[] candidates, int target, int start)
	{
		if (target == 0)
		{
			result.Add(new List<int>(combination));
			return;
		}

		for (int i = start; i < candidates.Length; i++)
		{
			if(target<candidates[i]) break;
			combination.Add(candidates[i]);
			CombinationSum(candidates, target - candidates[i], i);
			combination.Remove(candidates[i]);
		}
	}
}