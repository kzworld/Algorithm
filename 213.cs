/* 213. House Robber II    Difficulty: Medium

After robbing those houses on that street, the thief has found himself a new place for his thievery so that he will not get too much attention. This time, all houses at this place are arranged in a circle. That means the first house is the neighbor of the last one. Meanwhile, the security system for these houses remain the same as for those in the previous street.

Given a list of non-negative integers representing the amount of money of each house, determine the maximum amount of money you can rob tonight without alerting the police.*/

public class Solution {
	public int Rob(int[] nums) {
		if (nums.Length == 1) return nums[0];
		return Math.Max(rob(nums, 0, nums.Length - 2), rob(nums, 1, nums.Length - 1));
	}

	private int rob(int[] num, int lo, int hi) {
		int include = 0, exclude = 0;
		for (int j = lo; j <= hi; j++) {
			int i = include, e = exclude;
			include = e + num[j];
			exclude = Math.Max(e, i);
		}

		return Math.Max(include, exclude);
	}
}

/* solution
Since this question is a follow-up to House Robber, we can assume we already have a way to solve the simpler question, i.e. given a 1 row of house, we know how to rob them. So we already have such a helper function. We modify it a bit to rob a given range of houses.

private int rob(int[] num, int lo, int hi) {
    int include = 0, exclude = 0;
    for (int j = lo; j <= hi; j++) {
        int i = include, e = exclude;
        include = e + num[j];
        exclude = Math.max(e, i);
    }
    return Math.max(include, exclude);
}

Now the question is how to rob a circular row of houses. It is a bit complicated to solve like the simpler question. It is because in the simpler question whether to rob num[lo] is entirely our choice. But, it is now constrained by whether num[hi] is robbed.

However, since we already have a nice solution to the simpler problem. We do not want to throw it away. Then, it becomes how can we reduce this problem to the simpler one. Actually, extending from the logic that if house i is not robbed, then you are free to choose whether to rob house i + 1, you can break the circle by assuming a house is not robbed.

For example, 1 -> 2 -> 3 -> 1 becomes 2 -> 3 if 1 is not robbed.

Since every house is either robbed or not robbed and at least half of the houses are not robbed, the solution is simply the larger of two cases with consecutive houses, i.e. house i not robbed, break the circle, solve it, or house i + 1 not robbed. Hence, the following solution. I chose i = n and i + 1 = 0 for simpler coding. But, you can choose whichever two consecutive ones.

public int rob(int[] nums) {
    if (nums.length == 1) return nums[0];
    return Math.max(rob(nums, 0, nums.length - 2), rob(nums, 1, nums.length - 1));
}


*/

/*
[思路]

House Robber I的升级版. 因为第一个element 和最后一个element不能同时出现. 则分两次call House Robber I. case 1: 不包括最后一个element. case 2: 不包括第一个element.

两者的最大值即为全局最大值

[CODE]

[java] view plain copy
在CODE上查看代码片派生到我的代码片
*/
    public class Solution {
	//1 2 3  
        public int rob(int[] nums) {
		if(nums == null || nums.length == 0) return 0;
		if(nums.length == 1) return nums[0];
		if(nums.length == 2) return Math.max(nums[0], nums[1]);
		return Math.max(robsub(nums, 0, nums.length-2), robsub(nums, 1, nums.length-1));
	}

	private int robsub(int[] nums, int s, int e) {
		int n = e - s + 1;
		int[] d = new int[n];
		d[0] = nums[s];
		d[1] = Math.max(nums[s], nums[s+1]);

		for(int i = 2; i<n; i++) {
			d[i] = Math.max(d[i-2]+nums[s+i], d[i-1]);
		}

		return d[n-1];
	}
}