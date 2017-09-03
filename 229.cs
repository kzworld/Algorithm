/*229. Majority Element II

    Total Accepted: 36226
    Total Submissions: 134965
    Difficulty: Medium

Given an integer array of size n, find all elements that appear more than ⌊ n/3 ⌋ times. The algorithm should run in linear time and in O(1) space.*/
public class Solution {
	public IList<int> MajorityElement(int[] nums) {
		IList<int> result = new List<int>();
		Dictionary<int, int> dic = new Dictionary<int, int>();
		if(nums.Length == 0) return result;
		for(int i = 0;i<nums.Length;i++)
		{
			if(dic.ContainsKey(nums[i]))
				dic[nums[i]]++;
			else
				dic.Add(nums[i], 0);
			if(dic[nums[i]]>= (nums.Length/3)&&!result.Contains(nums[i])) result.Add(nums[i]);
		}

		return result;
	}
}