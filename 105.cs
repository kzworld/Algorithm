/*105. Construct Binary Tree from Preorder and Inorder Traversal
    Difficulty: Medium

Given preorder and inorder traversal of a tree, construct the binary tree.*/
public class Solution {
	public TreeNode BuildTree(int[] preorder, int[] inorder) {
		if (preorder.Length == 0) return null;
		return buildTree(preorder, inorder, 0, 0, inorder.Length - 1);
	}

	private TreeNode buildTree(int[] preorder, int[] inorder, int preorderIndex, int start, int end) {
		if (start > end) return null;
		TreeNode node = new TreeNode(preorder[preorderIndex]);
		int inorderIndex = findInorderIndex(inorder, start, end, preorder[preorderIndex]);
		int leftTreeSize = inorderIndex - start;
		int rightTreeSize = end - inorderIndex;
		node.left = buildTree(preorder, inorder, preorderIndex + 1, start, inorderIndex - 1);
		node.right = buildTree(preorder, inorder, preorderIndex + leftTreeSize + 1, inorderIndex + 1, end);
		return node;
	}

	private int findInorderIndex(int[] inorder, int start, int end, int key) {
		for (int i = start; i <= end; i++) {
			if (inorder[i] == key) return i;
		}

		return -1;
	}
}

/*
通过一棵二叉树的前序和中序排列来得出它的树形结构。
输入: preorder = [3,9,20,15,14,7], inorder = [9,3,14,15,20,7]
输出:

    3
   / \
  9  20
    /  \
   15   7
  /
 14
解题思路

    因为先序中的节点为根节点,所以取出先序的第一个节点
    用先序的第一个节点可以将中序分成左右子树，然后取出先序的第二个节点将左右子树再次划分
    当将中序全部划分为单个点时就结束
开始递归的时候用了列表作为参数，结果内存溢出，改用下标作参数，先序和中序序列作为全局变量。*/