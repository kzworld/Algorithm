/* 453. Minimum Moves to Equal Array Elements

    Total Accepted: 9580
    Total Submissions: 20856
    Difficulty: Easy
    Contributors: amehrotra2610

Given a non-empty integer array of size n, find the minimum number of moves required to make all array elements equal, where a move is incrementing n - 1 elements by 1.

Example:

Input:
[1,2,3]

Output:
3

Explanation:
Only three moves are needed (remember each move increments two elements):

[1,2,3]  =>  [2,3,3]  =>  [3,4,3]  =>  [4,4,4]
*/
public class Solution
{
    public int MinMoves(int[] nums)
    {
        // decreasing all but 1 element by 1 is same as increasing 1 element
        int min = nums[0];

        foreach (int num in nums)
        {
            min = num < min ? num : min;
        }

        int steps = 0;

        foreach (int num in nums)
        {
            steps += num - min;
        }
        return steps;
    }
}