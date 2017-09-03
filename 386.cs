386. Lexicographical Numbers
/*
Given an integer n, return 1 - n in lexicographical order.

For example, given 13, return: [1,10,11,12,13,2,3,4,5,6,7,8,9]. 
*/
 public class Solution {
    public IList<int> LexicalOrder(int n) {
        IList<int> list = new List<int>(n);
        int curr = 1;
        for (int i = 1; i <= n; i++) 
		{
			/*n means: n of numbers*/
		/*	1,10,11,12,13
			2,20
			3,
			4 etc.
		*/
            list.Add(curr);
            if (curr * 10 <= n) {
                curr *= 10;
            } else if (curr % 10 != 9 && curr + 1 <= n) {
                curr++;
            } else {
                while ((curr / 10) % 10 == 9) {
                    curr /= 10;
                }
                curr = curr / 10 + 1;
					}
        }
        return list;
    }
}