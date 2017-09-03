/*179. Largest Number

    Total Accepted: 54163
    Total Submissions: 265668
    Difficulty: Medium

Given a list of non negative integers, arrange them such that they form the largest number.

For example, given [3, 30, 34, 5, 9], the largest formed number is 9534330.

Note: The result may be very large, so you need to return a string instead of an integer.*/

public class Solution {
	    public string LargestNumber(int[] nums) {
    Array.Sort(nums,compare);      //0->9999 larger Sort
    if(nums[0]==0) return "0";
    StringBuilder res=new StringBuilder();
    for(int i=0;i<nums.Length;i++)
    {
        res.Append(nums[i]);
    }
    return res.ToString();
    }
    
    public int compare(int a,int b)
    {
        return (b+""+a).CompareTo(a+""+b);
    }
}