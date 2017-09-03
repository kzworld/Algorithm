/*
16. 3Sum Closest

    Total Accepted: 90794
    Total Submissions: 302726
    Difficulty: Medium

Given an array S of n integers, find three integers in S such that the sum is closest to a given number, target. Return the sum of the three integers. You may assume that each input would have exactly one solution.

    For example, given array S = {-1 2 1 -4}, and target = 1.

    The sum that is closest to the target is 2. (-1 + 2 + 1 = 2).
*/
public class Solution
{
    public int ThreeSumClosest(int[] nums, int target)
    {
        //Array Sort This array is Extremely Important Step because it causes pointers move through the array without misisng one.
        Array.Sort(nums);

        int closest = nums[0] + nums[1] + nums[2];
        int low, high;

        for (int i = 0; i < nums.Length - 1; i++)
        {
            low = i + 1;
            high = nums.Length - 1;
            //nums[i] In iterate in 1 step pointers start here Low and High
            while (low < high)
            {
                //If 3 Nums Equal To Target Return;
                if (nums[low] + nums[high] == target - nums[i]) return target;
                //Compare nums[low] + nums[high] to  target - nums[i] Then Manipulate low or high position and Find Closer Number to Target

                //Get Closest Number Higher Than Target
                if (nums[low] + nums[high] > target - nums[i])
                {
                    while (low < high && nums[low] + nums[high] > target - nums[i]) high--;
                    if (Math.Abs(nums[i] + nums[low] + nums[high + 1] - target) < Math.Abs(closest - target))
                        closest = nums[i] + nums[low] + nums[high + 1];
                }

                //Get Closest Number Lower Than Target
                if (nums[low] + nums[high] < target - nums[i])
                {
                    while (low < high && nums[low] + nums[high] < target - nums[i]) low++;
                    if (Math.Abs(nums[i] + nums[low - 1] + nums[high] - target) < Math.Abs(closest - target))
                        closest = nums[i] + nums[low - 1] + nums[high];
                }
            }
        }
        return closest;
    }

}