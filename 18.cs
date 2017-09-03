/*18. 4Sum

    Total Accepted: 85211
    Total Submissions: 343466
    Difficulty: Medium

Given an array S of n integers, are there elements a, b, c, and d in S such that a + b + c + d = target? Find all unique quadruplets in the array which gives the sum of target.

Note: The solution set must not contain duplicate quadruplets.

For example, given array S = [1, 0, -1, 0, -2, 2], and target = 0.

A solution set is:
[
  [-1,  0, 0, 1],
  [-2, -1, 1, 2],
  [-2,  0, 0, 2]
]
*/
public class Solution {
	public IList<IList<int>> FourSum(int[] nums, int target) {
		IList<IList<int>> ret = new List<IList<int>>();
		if(nums.Length <= 3) //invalid corner case check
    return ret;
		Array.Sort(nums);
		for(int i = 0; i < nums.Length-3; ++i)
		{
			if(i > 0 && nums[i] == nums[i-1])continue;
			for(int j = i+1; j < nums.Length-2; ++j)
			{
				if(j > i+1 && nums[j] == nums[j-1])continue;

				int k = j+1;
				int l = nums.Length-1;
				while(k < l)
				{
					int sum = nums[i]+nums[j]+nums[k]+nums[l];
					if(sum == target)
					{
						IList<int> curr = new List<int>();
						curr.Add(nums[i]);
						curr.Add(nums[j]);
						curr.Add(nums[k]);
						curr.Add(nums[l]);
						ret.Add(curr);

					
						while(k<l && nums[k++] == nums[k]);
						while(k<l && nums[l--] == nums[l]);
					}
					else if(sum < target)
						k++; 
						else
						l--;
				}
			}
		}

		return ret;
	}
}