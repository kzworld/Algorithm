/*
80. Remove Duplicates from Sorted Array II

    Total Accepted: 86378
    Total Submissions: 254749
    Difficulty: Medium

Follow up for "Remove Duplicates":
What if duplicates are allowed at most twice?

For example,
Given sorted array nums = [1,1,1,2,2,3],

Your function should return length = 5, with the first five elements of nums being 1, 1, 2, 2 and 3. It doesn't matter what you leave beyond the new length. 
*/
public class Solution {
	public int RemoveDuplicates(int[] nums) {
		if(nums.Length<1) return 0;
		int j = 0;
		int num = 0;
		for(int i = 1;i<nums.Length;i++)
		{
			if(nums[j] == nums[i])
			{
				num++;
				if(num<2)
				{
					nums[++j] = nums[i];
				}
			}
			else
			{
				nums[++j] = nums[i];
				num = 0;
			}
		}

		return j+1;
	}
}