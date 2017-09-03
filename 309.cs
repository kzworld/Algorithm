/*309. Best Time to Buy and Sell Stock with Cooldown

    Total Accepted: 24187
    Total Submissions: 62515
    Difficulty: Medium

Say you have an array for which the ith element is the price of a given stock on day i.

Design an algorithm to find the maximum profit. You may complete as many transactions as you like (ie, buy one and sell one share of the stock multiple times) with the following restrictions:

    You may not engage in multiple transactions at the same time (ie, you must sell the stock before you buy again).
    After you sell your stock, you cannot buy stock on next day. (ie, cooldown 1 day)

Example:

prices = [1, 2, 3, 0, 2]
maxProfit = 3
transactions = [buy, sell, cooldown, buy, sell]*/

public class Solution {
	public int MaxProfit(int[] prices) {
		/*We have 3 variables:
		Sell(i): the optimal solution when stock is sold on day i
		Buy(i): the optimal solution when stock is hold/bought on day i
		Rest(i): the optimal solution when stock was sold in advance, and we do nothing on day i (i.e. cool down)

		Then we can come up with following equations:
		
			The optimal solution of sell the stock on day(i) is:
			Sell(i) = Buy(i-1) + prices[i];
			The optimal solution of buy the stock on day(i) is:
			Buy(i) = max(Buy(i-1), Rest(i-1) - prices[i]);
			The optimal solution of cool-down on day(i) is:
			Rest(i) = max(Rest(i-1), Sell(i-1))
		
		Then we can come up with the following piece of code:

		*/
    int prevSell = 0, prevRest = 0, prevBuy = int.MinValue;
		for(int i = 0; i < prices.Length; i++) {
			int newBuy = Math.Max(prevBuy, prevRest-prices[i]);

			prevRest = Math.Max(prevSell, prevRest);
			prevSell = prevBuy+prices[i];
			prevBuy = newBuy;
		}

		return Math.Max(prevRest, prevSell);
	}
}