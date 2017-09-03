/*
 199. Binary Tree Right Side View

    Total Accepted: 62330
    Total Submissions: 162906
    Difficulty: Medium
    Contributors: Admin

Given a binary tree, imagine yourself standing on the right side of it, return the values of the nodes you can see ordered from top to bottom.

For example:
Given the following binary tree,

   1            <---
 /   \
2     3         <---
 \     \
  5     4       <---

You should return [1, 3, 4]. 
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
	private IList<int> result = new List<int>();
	public IList<int> RightSideView(TreeNode root) {
		rightView(root, 0);
		return result;
	}

	public void rightView(TreeNode curr, int currDepth) {
		if(curr == null) {
			return;
		}

		if(currDepth == result.Count) {
			result.Add(curr.val);
		}

		rightView(curr.right, currDepth + 1);
		rightView(curr.left, currDepth + 1);
	}
}