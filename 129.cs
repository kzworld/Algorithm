/*
129. Sum Root to Leaf Numbers

    Total Accepted: 92799
    Total Submissions: 268348
    Difficulty: Medium
    Contributors: Admin

Given a binary tree containing digits from 0-9 only, each root-to-leaf path could represent a number.

An example is the root-to-leaf path 1->2->3 which represents the number 123.

Find the total sum of all root-to-leaf numbers.

For example,

    1
   / \
  2   3

The root-to-leaf path 1->2 represents the number 12.
The root-to-leaf path 1->3 represents the number 13.

Return the sum = 12 + 13 = 25. 
*/

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
	public int SumNumbers(TreeNode root) {
		int res = 0;
		if(root == null)
			return res;
		SumNumbersHelper(root, 0, ref res);
		return res;
	}

	private void SumNumbersHelper(TreeNode root, int cur, ref int res)
	{
		cur = cur*10 + root.val;
		if(root.left == null && root.right == null)//leaf
		{
			res += cur;
			return;
		}

		if(root.left!= null)
			SumNumbersHelper(root.left, cur, ref res);
		if(root.right!= null)
			SumNumbersHelper(root.right, cur, ref res);
	}
}