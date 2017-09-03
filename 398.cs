'''
 398. Random Pick Index

    Total Accepted: 9750
    Total Submissions: 25201
    Difficulty: Medium
    Contributors: Admin

Given an array of integers with possible duplicates, randomly output the index of a given target number. You can assume that the given target number must exist in the array.

Note:
The array size can be very large. Solution that uses too much extra space will not pass the judge.

Example:

int[] nums = new int[] {1,2,3,3,3};
Solution solution = new Solution(nums);

// pick(3) should return either index 2, 3, or 4 randomly. Each index should have equal probability of returning.
solution.pick(3);

// pick(1) should return 0. Since in the array only nums[0] is equal to 1.
solution.pick(1);
'''
from random import random
class Solution(object):
    def __init__(self, nums):
        """
        :type nums: List[int]
        :type numsSize: int
        """
        self.nums = nums

    def pick(self, target):
        """
        :type target: int
        :rtype: int
        """
        cnt, index = 0, 0
        for idx, x in enumerate(self.nums):
            if x == target:
                cnt += 1
                if random() <= 1.0/(cnt):
                    index = idx
        return index
		
'''explanation

    Do we want to optimize run time or memory?If we want to optimize run time then we can use a dictionary to pre-process the nums array. Simply create a map of key (number) and value (list of its indices). Then run reservoir sampling over this input.
    But the problem statement says that using too much memory is not allowed. In that case, we can iterate the entire array and keep a variable to track the frequency of the target for input into reservoir sampling.
    Notice random() returns uniform random number between [0 to 1]
'''

'''Jave Solution
public class Solution {

    int[] nums;
    Random rnd;

    public Solution(int[] nums) {
        this.nums = nums;
        this.rnd = new Random();
    }
    
    public int pick(int target) {
        int result = -1;
        int count = 0;
        for (int i = 0; i < nums.length; i++) {
            if (nums[i] != target)
                continue;
            if (rnd.nextInt(++count) == 0)
                result = i;
        }
        
        return result;
    }
}
```