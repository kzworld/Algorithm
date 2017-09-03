/*2. Add Two Numbers

    Total Accepted: 172618
    Total Submissions: 698614
    Difficulty: Medium

You are given two linked lists representing two non-negative numbers. The digits are stored in reverse order and each of their nodes contain a single digit. Add the two numbers and return it as a linked list.

Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
Output: 7 -> 0 -> 8*/
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
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
	public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
		ListNode res = new ListNode(0);
		ListNode n = res;

		int result = 0;
		while(l1!= null||l2!= null)
		{
			result/= 10;
			if(l1!= null) { result+= l1.val; l1 = l1.next; }
			if(l2!= null) { result+= l2.val; l2 = l2.next; }

			n.next = new ListNode(result%10);
			n = n.next;
		}
		/*May have an additional digit 1*/
		if (result/10 == 1)n.next = new ListNode(1);
		return res.next;
	}
}