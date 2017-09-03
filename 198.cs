/*
198. House Robber •Difficulty: Easy
You are a professional robber planning to rob houses along a street. Each house has a certain amount of money stashed, the only constraint stopping you from robbing each of them is that adjacent houses have security system connected and it will automatically contact the police if two adjacent houses were broken into on the same night.

Given a list of non-negative integers representing the amount of money of each house, determine the maximum amount of money you can rob tonight without alerting the police.
*/
public class Solution
{
    public int Rob(int[] nums)
    {
        int a = 0;
        int b = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (i % 2 == 0)
            {
                a = Math.Max(a + nums[i], b);
            }
            else
            {
                b = Math.Max(a, b + nums[i]);
            }
        }

        return Math.Max(a, b);
    }
}