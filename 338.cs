/*338. Counting Bits

    Total Accepted: 42388
    Total Submissions: 72687
    Difficulty: Medium

Given a non negative integer number num. For every numbers i in the range 0 ≤ i ≤ num calculate the number of 1's in their binary representation and return them as an array.

Example:
For num = 5 you should return [0,1,1,2,1,2]. */

public class Solution {
	public int[] CountBits(int num) {
		int[] res = new int[num+1];
		int pow2 = 1, before = 1;
		for(int i = 1;i<= num;i++) {
			if (i == pow2) {
				before = res[i] = 1;
				pow2 <<= 1;
			}
			else {
				res[i] = res[before] + 1;
				before += 1;
			}
		}

		return res;
	}
}