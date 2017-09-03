/*260. Single Number III

    Total Accepted: 45736
    Total Submissions: 97502
    Difficulty: Medium

Given an array of numbers nums, in which exactly two elements appear only once and all the other elements appear exactly twice. Find the two elements that appear only once.

For example:

Given nums = [1, 2, 1, 3, 2, 5], return [3, 5].

Note:

    The order of the result is not important. So in the above example, [5, 3] is also correct.
    Your algorithm should run in linear runtime complexity. Could you implement it using only constant space complexity?
*/
public class Solution {
	public int[] SingleNumber(int[] nums) {
		List<int> listnums = new List<int>();
		List<int> listresult = new List<int>();
		foreach (int num in nums)
		{
			if(!listnums.Contains(num))
			{ listnums.Add(num); }
			else
			{
				listresult.Add(num);
			}
		}

		foreach (int removeint in listresult)
		{
			listnums.Remove(removeint);
		}

		return listnums.ToArray();
	}
}