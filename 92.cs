/*
 92. Reverse Linked List II

    Total Accepted: 89510
    Total Submissions: 303304
    Difficulty: Medium
    Contributors: Admin

Reverse a linked list from position m to n. Do it in-place and in one-pass.

For example:
Given 1->2->3->4->5->NULL, m = 2 and n = 4,

return 1->4->3->2->5->NULL.

Note:
Given m, n satisfy the following condition:
1 ≤ m ≤ n ≤ length of list. 
*/
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
	public ListNode ReverseBetween(ListNode head, int m, int n) {
		if(m == n) return head;
		ListNode fake = new ListNode(0);
		ListNode p = fake;
		fake.next = head;
		for(int i = 0; i < (m-1); i++) p = p.next;
		ListNode prev = p;
		ListNode next = null;
		ListNode bound = prev;
		p = p.next;
		for(int i = m; i < (n+1); i++) {
			next = p.next;
			p.next = prev;
			prev = p;
			p = next;
		}

		bound.next.next = next;
		bound.next = prev;
		return fake.next;
	}
}