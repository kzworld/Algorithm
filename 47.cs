/*
47. Permutations II

    Total Accepted: 92171
    Total Submissions: 305290
    Difficulty: Medium
    Contributors: Admin

Given a collection of numbers that might contain duplicates, return all possible unique permutations.

For example,
[1,1,2] have the following unique permutations:

[
  [1,1,2],
  [1,2,1],
  [2,1,1]
]
*/
public class Solution {
	public IList<IList<int>> PermuteUnique(int[] nums) {
		Array.Sort(nums);
		var result = new List<IList<int>>();
		DFS(nums, result, new Dictionary<int, int>());
		return result;
	}

	public void DFS(int[]nums, IList<IList<int>> result, Dictionary<int, int> curr)
	{
		if(curr.Count == nums.Length)
		{
			result.Add(curr.Values.ToList());
			return;
		}

		for(int i = 0; i < nums.Length; i++)
		{
			if(!curr.ContainsKey(i))
			{
				//colone list
            var newList = new Dictionary<int, int>();
				foreach(var item in curr)
				{
					newList.Add(item.Key, item.Value);
				}

				newList.Add(i, nums[i]);
				DFS(nums, result, newList);

				while(i<nums.Length-1 && nums[i+1] == nums[i])
				{
					i += 1;
				}
			}
		}
	}
}