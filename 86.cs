/*
 86. Partition List

    Total Accepted: 83058
    Total Submissions: 265725
    Difficulty: Medium
    Contributors: Admin

Given a linked list and a value x, partition it such that all nodes less than x come before nodes greater than or equal to x.

You should preserve the original relative order of the nodes in each of the two partitions.

For example,
Given 1->4->3->2->5->2 and x = 3,
return 1->2->2->4->3->5. 
*/
public class Solution {
	public ListNode Partition(ListNode head, int x) {
		ListNode dummy1 = new ListNode(0), dummy2 = new ListNode(0); //dummy heads of the 1st and 2nd queues
		ListNode curr1 = dummy1, curr2 = dummy2; //current tails of the two queues;
		while (head!= null) {
			if (head.val<x) {
				curr1.next = head;
				curr1 = head;
			}else {
				curr2.next = head;
				curr2 = head;
			}

			head = head.next;
		}
//important! avoid cycle in linked list. otherwise u will get TLE.
		curr2.next = null; 
		curr1.next = dummy2.next;
		return dummy1.next;
	}
}