/*216. Combination Sum III

    Total Accepted: 42524
    Total Submissions: 108939
    Difficulty: Medium

Find all possible combinations of k numbers that add up to a number n, given that only numbers from 1 to 9 can be used and each combination should be a unique set of numbers.

Example 1:

Input: k = 3, n = 7

Output:

[[1, 2, 4]]

Example 2:

Input: k = 3, n = 9

Output:

[[1, 2, 6], [1, 3, 5], [2, 3, 4]]
*/
public class Solution {
	private IList<IList<int>> res = new List<IList<int>>();
	//k numbers add up to target n
	public IList<IList<int>> CombinationSum3(int k, int n) {
		IList<int> list = new List<int>();
		if(k > 9) return res;
		dfs(k, n, 1, 0, new List<int>());
		return res;
	}

	private void dfs(int k, int n, int s, int depth, IList<int> cur) {
		if(depth == k && n == 0) {
			res.Add(new List<int>(cur));
			return;
		}

		if(depth == k) return;
		for(int i = s; i <= 9; i++) {
			cur.Add(i);
			dfs(k, n-i, i+1, depth+1, cur);
			cur.Remove(i);
		}
	}
}