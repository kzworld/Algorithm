/*230. Kth Smallest Element in a BST

    Total Accepted: 61983
    Total Submissions: 154701
    Difficulty: Medium

Given a binary search tree, write a function kthSmallest to find the kth smallest element in it.

Note:
You may assume k is always valid, 1 ≤ k ≤ BST's total elements.

Follow up:
What if the BST is modified (insert/delete operations) often and you need to find the kth smallest frequently? How would you optimize the kthSmallest routine?
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
	public int KthSmallest(TreeNode root, int k) {
		int count = countNodes(root.left);
		if (k <= count) {
			return KthSmallest(root.left, k);
		}		else if (k > count + 1) {
			return KthSmallest(root.right, k-1-count); // 1 is counted as current node
		}

		return root.val;
	}

	public int countNodes(TreeNode n) {
		if (n == null) return 0;

		return 1 + countNodes(n.left) + countNodes(n.right);
	}
}