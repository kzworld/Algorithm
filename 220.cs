/* 220. Contains Duplicate III

    Total Accepted: 41499
    Total Submissions: 213165
    Difficulty: Medium
    Contributors: Admin

Given an array of integers, find out whether there are two distinct indices i and j in the array such that the difference between nums[i] and nums[j] is at most t and the difference between i and j is at most k.

Subscribe to see which companies asked this question
*/
public class Solution {
	public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t) {
		if(t < 0) return false;
		SortedSet<long> ss = new SortedSet<long>();
		for(int i = 0; i < nums.Length; i++) {
			//GetViewBetween (Min Value To Max Value)
			if(ss.GetViewBetween((long)nums[i] - t, (long)nums[i] + t).Count > 0) return true;
			ss.Add(nums[i]);
			if(i >= k) ss.Remove(nums[i - k]);
		}
		return false;
	}
}