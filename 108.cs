/*108. Convert Sorted Array to Binary Search Tree

    Total Accepted: 88156
    Total Submissions: 225897
    Difficulty: Medium

Given an array where elements are sorted in ascending order, convert it to a height balanced BST.*/
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
	public TreeNode SortedArrayToBST(int[] nums) {
		if (nums == null || nums.Length == 0)
			return null;
		return recursionNode(nums, 0, nums.Length - 1);
	}

	private TreeNode recursionNode(int[] nums, int start, int end) {
		if (start > end) return null;
		if (start == end) return new TreeNode(nums[start]);
		int center = (end + 1 - start) / 2 + start;
		TreeNode root = new TreeNode(nums[center]);
		root.left = recursionNode(nums, start, center - 1);
		root.right = recursionNode(nums, center + 1, end);
		return root;
	}
}