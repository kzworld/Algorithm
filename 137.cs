/*137. Single Number II

    Total Accepted: 94522
    Total Submissions: 242333
    Difficulty: Medium

Given an array of integers, every element appears three times except for one. Find that single one.

Note:
Your algorithm should have a linear runtime complexity. Could you implement it without using extra memory? */
public class Solution {
	public int SingleNumber(int[] nums) {
		Dictionary<int, int> dic = new Dictionary<int, int>();
		for(int i = 0;i<nums.Length;i++)
		{
			if(dic.ContainsKey(nums[i])) dic[nums[i]]++;			else
				dic.Add(nums[i], 0);
		}

		foreach(KeyValuePair<int, int> p in dic)
		{
			if(p.Value == 0) return p.Key;
		}

		return nums[0];
	}
}