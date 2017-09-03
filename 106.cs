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
	public TreeNode BuildTree(int[] inorder, int[] postorder) {
		if (postorder.Length == 0) return null;
		return buildBST(inorder, postorder, postorder.Length-1, 0, postorder.Length-1);
	}

	private TreeNode buildBST(int[] inorder, int[] postorder, int postorderIndex, int start, int end) {
		if(start > end) return null;
		TreeNode node = new TreeNode(postorder[postorderIndex]);
		int inorderIndex = findInorderIndex(inorder, start, end, postorder[postorderIndex]);

		int leftTreeSize = inorderIndex-start;
		int rightTreeSize = end-inorderIndex;

		node.left = buildBST(inorder, postorder, postorderIndex - end +inorderIndex - 1, start, inorderIndex-1);
		node.right = buildBST(inorder, postorder, postorderIndex-1, inorderIndex+1, end);
		return node;
	}

	private int findInorderIndex(int[] inorder, int start, int end, int key) {
		for(int i = start;i<= end;i++) {
			if(inorder[i] == key) return i;
		}

		return -1;
	}
}