/*347. Top K Frequent Elements

    Total Accepted: 27731
    Total Submissions: 63071
    Difficulty: Medium

Given a non-empty array of integers, return the k most frequent elements.

For example,
Given [1,1,1,2,2,3] and k = 2, return [1,2].

Note:

    You may assume k is always valid, 1 ≤ k ≤ number of unique elements.
    Your algorithm's time complexity must be better than O(n log n), where n is the array's size.
*/
public class Solution {
	public IList<int> TopKFrequent(int[] nums, int k) {
		Dictionary<int, int> dic = new Dictionary<int, int>();
		IList<int> res = new List<int>();
		foreach(int num in nums)
		{
			if(dic.ContainsKey(num)) dic[num]++;			else dic.Add(num, 1);
		}
		int count = 0;
		/*Order by descending to get the most top key.value pairs and add to result list*/
		foreach(KeyValuePair<int, int> pair in dic.OrderByDescending(key => key.Value))
		{

			// Console.WriteLine(pair.Key+"  "+pair.Value);
			res.Add(pair.Key);
			count++;
			if (count == k) break;
		}
		return res;
	}
}