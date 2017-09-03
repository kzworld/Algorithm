/*61. Rotate List    Difficulty: Medium

Given a list, rotate the list to the right by k places, where k is non-negative.

For example:
Given 1->2->3->4->5->NULL and k = 2,
return 4->5->1->2->3->NULL.*/
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
	public ListNode RotateRight(ListNode head, int k) {
		IList<ListNode> list = new List<ListNode>();
		while(head!= null)
		{
			list.Add(head);
			head = head.next;
		}

		if(list.Count == 0) return null;		else k = list.Count-k%list.Count;
		ListNode result = new ListNode(0);
		ListNode p = result;

		for(int i = k;i<list.Count;i++)
		{			
			result.next = new ListNode(list[i].val);
			result = result.next;
		}

		for(int i = 0;i<k;i++)
		{
			result.next = new ListNode(list[i].val);
			result = result.next;			
		}

		return p.next;
	}
}