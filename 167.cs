/*167. Two Sum II - Input array is sorted

    Total Accepted: 20931
    Total Submissions: 42725
    Difficulty: Medium

Given an array of integers that is already sorted in ascending order, find two numbers such that they add up to a specific target number.

The function twoSum should return indices of the two numbers such that they add up to the target, where index1 must be less than index2. Please note that your returned answers (both index1 and index2) are not zero-based.

You may assume that each input would have exactly one solution.

Input: numbers={2, 7, 11, 15}, target=9
Output: index1=1, index2=2 */

public class Solution {
	public int[] TwoSum(int[] numbers, int target) {
		int len = numbers.Length;
		int i = 0, j = len-1, sum = 0;
		while (i < j) {
			sum = numbers[i] + numbers[j];
			if(sum == target) break;
			else if (sum < target) i++;
			else j--;
		}

		return new int[] { i+1, j+1 };
	}
}