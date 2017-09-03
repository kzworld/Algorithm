/*
 95. Unique Binary Search Trees II

    Total Accepted: 68818
    Total Submissions: 227358
    Difficulty: Medium
    Contributors: Admin

Given an integer n, generate all structurally unique BST's (binary search trees) that store values 1...n.

For example,
Given n = 3, your program should return all 5 unique BST's shown below.

   1         3     3      2      1
    \       /     /      / \      \
     3     2     1      1   3      2
    /     /       \                 \
   2     1         2                 3

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
	public IList<TreeNode> GenerateTrees(int n) {
		if(n == 0) {
			return new List<TreeNode>();
		}

		return helper(1, n);
	}

	public List<TreeNode> helper(int m, int n) {
		List<TreeNode> result = new List<TreeNode>();
		if(m>n) {
			result.Add(null);
			return result;
		}

		for(int i = m; i<= n; i++) {
			List<TreeNode> ls = helper(m, i-1);
			List<TreeNode> rs = helper(i+1, n);
			foreach(TreeNode l in ls) {
				foreach(TreeNode r in rs) {
					TreeNode curr = new TreeNode(i);
					curr.left = l;
					curr.right = r;
					result.Add(curr);
				}
			}
		}

		return result;
	}
}