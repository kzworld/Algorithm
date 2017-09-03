/*
 349. Intersection of Two Arrays

    Total Accepted: 64377
    Total Submissions: 141797
    Difficulty: Easy
    Contributors: Admin

Given two arrays, write a function to compute their intersection.

Example:
Given nums1 = [1, 2, 2, 1], nums2 = [2, 2], return [2].

Note:

    Each element in the result must be unique.
    The result can be in any order.

*/
public class Solution
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        HashSet<int> set = new HashSet<int>(nums1);
        HashSet<int> result = new HashSet<int>();

        for (int i = 0; i < nums2.Length; i++)
        {
            if (set.Contains(nums2[i])) result.Add(nums2[i]);
        }

        int[] resultints = result.ToArray();
        return resultints;
    }
}