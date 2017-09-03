/*377. Combination Sum IV

    Total Accepted: 8913
    Total Submissions: 22370
    Difficulty: Medium

Given an integer array with all positive numbers and no duplicates, find the number of possible combinations that add up to a positive integer target.

Example:

nums = [1, 2, 3]
target = 4

The possible combination ways are:
(1, 1, 1, 1)
(1, 1, 2)
(1, 2, 1)
(1, 3)
(2, 1, 1)
(2, 2)
(3, 1)

Note that different sequences are counted as different combinations.

Therefore the output is 7.

Follow up:
What if negative numbers are allowed in the given array?
How does it change the problem?
What limitation we need to add to the question to allow negative numbers? */

public class Solution {
	public int CombinationSum4(int[] nums, int target) {
		int[] dp = new int[target+1];
		dp[0] = 1;
		/*Get every number 's combinations dp up to the target*/
		for(int i = 0;i<target;i++)
		{
			foreach(int num in nums)
			{			
		/*i+num is the possible number others won't get up to target*/
				if(i+num<= target) dp[i+num]+= dp[i];		
			}
		}
		return dp[target];
	}
}
/* 
if(i+num<= target) {
	Console.WriteLine(i+"  "+num+"   "+(i+num)+"  "+dp[i+num]+"  "+dp[i]);
	dp[i+num]+= dp[i];	
}

[1,3,4]
10

Your stdout
i	num		i+num	dp[i+num]	dp[i]
0  	1   	1  		0  			1
0  	3   	3  		0  			1
0  	4   	4  		0  			1
1  	1   	2  		0  			1
1  	3   	4  		1  			1
1  	4   	5  		0  			1
2  	1   	3  		1  			1
2  	3   	5  		1  			1
2  	4   	6  		0  			1
3  	1   	4  		2  			2
3  	3   	6  		1  			2
3  	4   	7  		0  			2
4  	1   	5  		2  			4
4  	3   	7  		2  			4
4  	4   	8  		0  			4
5  	1   	6  		3  			6
5  	3   	8  		4  			6
5  	4   	9  		0  			6
6  	1   	7  		6  			9
6  	3   	9  		6  			9
6  	4   	10 		0 			9
7  	1   	8  		10 			15
7  	3   	10 		9 			15
8  	1   	9  		15 			25
9  	1   	10 		24			40
*/	