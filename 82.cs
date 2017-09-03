/*82. Remove Duplicates from Sorted List II

    Total Accepted: 82835
    Total Submissions: 297173
    Difficulty: Medium

Given a sorted linked list, delete all nodes that have duplicate numbers, leaving only distinct numbers from the original list.

For example,
Given 1->2->3->3->4->4->5, return 1->2->5.
Given 1->1->1->2->3, return 2->3. */
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
	public ListNode DeleteDuplicates(ListNode head) {
		if(head == null) return head;
		ListNode t = new ListNode(0);
		t.next = head;
		ListNode p = t;
		while(p.next!= null&&p.next.next!= null)
		{
			if(p.next.val == p.next.next.val)
			{
				int dup = p.next.val;
				while(p.next!= null&&p.next.val == dup)
				{
					p.next = p.next.next;
				}
			}
			else
			{
				p = p.next;
			}
		}

		return t.next;
	}
}