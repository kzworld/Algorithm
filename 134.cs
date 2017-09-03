/*134. Gas Station

    Total Accepted: 73604
    Total Submissions: 259165
    Difficulty: Medium
    Contributors: Admin

There are N gas stations along a circular route, where the amount of gas at station i is gas[i].

You have a car with an unlimited gas tank and it costs cost[i] of gas to travel from station i to its next station (i+1). You begin the journey with an empty tank at one of the gas stations.

Return the starting gas station's index if you can travel around the circuit once, otherwise return -1.

Note:
The solution is guaranteed to be unique. */
public class Solution {
	public int CanCompleteCircuit(int[] gas, int[] cost) {
		for(int i = 0; i < gas.Length; i++) {
			gas[i] -= cost[i];
		}

		int sum = 0;
		int result = 0;
		int n = gas.Length;
		for(int i = 0; i < n * 2 - 1; i++) {
			sum += gas[i % n];
			if(sum < 0) {
				result = i + 1;
				if(result >= n) {
					return -1;
				}

				sum = 0;
			}
		}

		return result;
	}
}