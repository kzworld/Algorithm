/*122. Best Time to Buy and Sell Stock II

    Total Accepted: 101444
    Total Submissions: 230831
    Difficulty: Medium

Say you have an array for which the ith element is the price of a given stock on day i.

Design an algorithm to find the maximum profit. You may complete as many transactions as you like (ie, buy one and sell one share of the stock multiple times). However, you may not engage in multiple transactions at the same time (ie, you must sell the stock before you buy again).*/

public class Solution {
	public int MaxProfit(int[] prices) {
		int profit = 0;
		for(int i = 0;i<prices.Length-1;i++)
		{
			int profitloss = 0;
			profitloss = prices[i+1]-prices[i];
			profit+= (profitloss>0)?profitloss:0;
		}

		return profit;
	}
}