/* 322. Coin Change    Difficulty: Medium
   
You are given coins of different denominations and a total amount of money amount. Write a function to compute the fewest number of coins that you need to make up that amount. If that amount of money cannot be made up by any combination of the coins, return -1.

Example 1:
coins = [1, 2, 5], amount = 11
return 3 (11 = 5 + 5 + 1)

Example 2:
coins = [2], amount = 3
return -1.

You may assume that you have an infinite number of each kind of coin.
*/
public class Solution {
	//Recursive
    public int CoinChange(int[] coins, int amount)
	{
		if (amount < 1)		return 0;
		Array.Sort(coins);
		return helper(coins, amount, new int[amount]);
	}

	private int helper(int[] coins, int amount, int[] dp)
	{
		if (amount == 0)			return 0;
		if (dp[amount - 1] != 0)			return dp[amount - 1];
		int min = int.MaxValue;
		foreach (int coin in coins)
		{
			if (amount < coin)	break;
			int res = helper(coins, amount - coin, dp);
			if (res >= 0 && res < min) min = 1 + res;
		}
		dp[amount - 1] = (min == int.MaxValue) ? -1 : min;
		return dp[amount - 1];
	}
	//Iteration
	public int CoinChange(int[] coins, int amount)
	{
		if (amount < 1)			return 0;
		Array.Sort(coins);
		int[] dp = new int[amount + 1];
		int sum = 0;
		while (++sum <= amount)
		{
			int min = -1;
			foreach (int coin in coins)
			{
				if (sum < coin)					break;
				int pre = dp[sum - coin];
				if (pre != -1)
				{
					pre++;
					min = min < 0 ? pre : Math.Min(pre, min);
				}
			}
			dp[sum] = min;
		}
		return dp[amount];
	}
}