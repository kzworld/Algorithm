/*
 123. Best Time to Buy and Sell Stock III

    Total Accepted: 71439
    Total Submissions: 256233
    Difficulty: Hard
    Contributors: Admin

Say you have an array for which the ith element is the price of a given stock on day i.

Design an algorithm to find the maximum profit. You may complete at most two transactions.

Note:
You may not engage in multiple transactions at the same time (ie, you must sell the stock before you buy again).
*/
public class Solution {
	public int MaxProfit(int[] prices) {
		if (prices == null || prices.Length == 0) return 0;
		int length = prices.Length;
		int[] leftProfit = new int[length];
		int leftMaxProfit = 0;
		int leftMin = prices[0];
		for (int i = 0; i<length; i++) {
			if (prices[i] < leftMin) leftMin = prices[i];
			if (prices[i] - leftMin > leftMaxProfit) leftMaxProfit = prices[i]-leftMin;
			leftProfit[i] = leftMaxProfit;
		}

		int maxProfit = 0;
		int rightMaxProfit = 0;
		int rightMax = prices[length-1];
		for (int i = length-1; i>= 0; i--) {
			if (prices[i] > rightMax) 
				rightMax = prices[i];
			if (rightMax - prices[i] > rightMaxProfit) 
				rightMaxProfit = rightMax - prices[i];
			int currentProfit = rightMaxProfit + (i>0 ? leftProfit[i-1] : 0);
			if (currentProfit > maxProfit) 
				maxProfit = currentProfit;
			
		}
		return maxProfit;
	}
}