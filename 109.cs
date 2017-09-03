/* 109. Convert Sorted List to Binary Search Tree
    Difficulty: Medium
Given a singly linked list where elements are sorted in ascending order, convert it to a height balanced BST.*/

public class Solution {
	public TreeNode SortedListToBST(ListNode head) {
		if(head == null) return null;
		return toBST(head, null);
	}

	public TreeNode toBST(ListNode head, ListNode tail) {
		ListNode slow = head;
		ListNode fast = head;
		if(head == tail) return null;

		while(fast!= tail&&fast.next!= tail) {
			fast = fast.next.next;
			slow = slow.next;
		}

		TreeNode thead = new TreeNode(slow.val);
		thead.left = toBST(head, slow);
		thead.right = toBST(slow.next, tail);
		return thead;
	}
}
/*
给定一个升序的单向链表，将它转化为高度平衡的二叉搜索树
注意点：
    同一个序列转化成的二叉搜索树可能有多种
例子:
输入: nums = 1->2->3
输出:
  2
 / \
1   3

解题思路
这题就是 Convert Sorted Array to Binary Search Tree 的升级版，可以先把链表转化为列表再解答。如果直接用链表解决的话，可以看出链表的特点是从头到尾依次遍历，因为是递增的，所以也就是从小到大依次遍历。而二叉所搜树的中序遍历的结果就是一个递增的序列，所以只要按照树的中序遍历的方式来构造即可
*/