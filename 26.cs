/*
26. Remove Duplicates from Sorted Array •Difficulty: Easy
Given a sorted array, remove the duplicates in place such that each element appear only once and return the new length.
Do not allocate extra space for another array, you must do this in place with constant memory. 
For example,
 Given input array nums = [1,1,2], 
Your function should return length = 2, with the first two elements of nums being 1 and 2 respectively. It doesn't matter what you leave beyond the new length. 
*/
/*
C#
*/
public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if(nums.Length<=1) return nums.Length;
        int pos=1;
        for(int i=1;i<nums.Length;i++)
        {
            if(nums[i]!=nums[i-1]) nums[pos++]=nums[i];
        }
        return pos;
    }
}
/*
Javascript
*/
var removeDuplicates = function(nums) {
 
        if(nums.length<=1) return nums.length;
        var pos=1;
        for(var i=1;i<nums.length;i++)
        {
            if(nums[i]!=nums[i-1]) nums[pos++]=nums[i];
        }
        return pos;
};