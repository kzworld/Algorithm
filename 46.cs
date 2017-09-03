/*46. Permutations

    Total Accepted: 116585
    Total Submissions: 307326
    Difficulty: Medium

Given a collection of distinct numbers, return all possible permutations.

For example,
[1,2,3] have the following permutations:

[
  [1,2,3],
  [1,3,2],
  [2,1,3],
  [2,3,1],
  [3,1,2],
  [3,2,1]
]
*/
public class Solution {
	IList<IList<int>> list = new List<IList<int>>();
	public IList<IList<int>> Permute(int[] nums) {
		dfs(nums, 0, nums.Length);
		return list;
	}

	public void swap(int[] nums, int a, int b)
	{
		int temp = nums[a];
		nums[a] = nums[b];
		nums[b] = temp;
	}

	public void dfs(int[] nums, int ind, int len)
	{
		if(ind == len)
		{
			list.Add(nums.ToList());
		}
		else
		{
			for(int i = ind;i<len;i++)
			{
				swap(nums, ind, i);
				dfs(nums, ind+1, len);
				swap(nums, i, ind);
			}
		}
	}
}