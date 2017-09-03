/* 458. Poor Pigs

    Total Accepted: 99
    Total Submissions: 266
    Difficulty: Easy
    Contributors: yuhaowang001

There are 1000 buckets, one and only one of them contains poison, the rest are filled with water. They all look the same. If a pig drinks that poison it will die within 15 minutes. What is the minimum amount of pigs you need to figure out which bucket contains the poison within one hour.

Answer this question, and write an algorithm for the follow-up general case.

Follow-up:

If there are n buckets and a pig drinking poison will die within m minutes, how many pigs (x) you need to figure out the "poison" bucket within p minutes? There is exact one bucket with poison. 
*/
public class Solution {
	public int PoorPigs(int buckets, int minutesToDie, int minutesToTest) {
		//if bucket only has 1 then doesn't need pig.
		if(buckets-- == 1) return 0;
		//Test Minutes / Die Minutes +1     Test time that a pig need in a buckets
		int basenum = minutesToTest/minutesToDie+1;
		int count = 0;
		while (buckets>0) {
			buckets/= basenum;
			count++;
		}

		return count;
	}
}