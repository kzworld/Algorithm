/*25. Reverse Nodes in k-Group

    Total Accepted: 68509
    Total Submissions: 238654
    Difficulty: Hard

Given a linked list, reverse the nodes of a linked list k at a time and return its modified list.

If the number of nodes is not a multiple of k then left-out nodes in the end should remain as it is.

You may not alter the values in the nodes, only nodes itself may be changed.

Only constant memory is allowed.

For example,
Given this linked list: 1->2->3->4->5

For k = 2, you should return: 2->1->4->3->5

For k = 3, you should return: 3->2->1->4->5 */

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
	public ListNode ReverseKGroup(ListNode head, int k) {
		var KlengthList = new List<ListNode>();

		//divide the list into group

        KlengthList.Add(head);

		var runner = head;
		var newHeader = head;
		int length = 1;

		while(runner!= null)
		{
			if(length == k)
			{
				KlengthList.Add(runner.next);
				length = 1;
				var temp = runner.next;
				runner.next = null;
				runner = temp;
				continue;
			}

			length += 1;
			runner = runner.next;
		}

		var KlengthListEnd = new List<ListNode>();

		//reverse k length list

        for(int i = 0; i < KlengthList.Count - 1;i++)
		{
			KlengthListEnd.Add(ReverseList(KlengthList[i]));
		}

		if(length == k + 1)
		{
			KlengthListEnd.Add(ReverseList(KlengthList[KlengthList.Count - 1]));
		}
		else
		{
			KlengthListEnd.Add(KlengthList[KlengthList.Count - 1]);
		}

		//link reversed list together

        for(int i = 0; i < KlengthList.Count - 1;i++)
		{
			KlengthList[i].next = KlengthListEnd[i + 1];
		}

		return KlengthListEnd[0];
	}

	public ListNode ReverseList(ListNode head)
	{
		ListNode newHead = null;

		var next = head;

		while(next!= null)
		{
			var temp = next.next;
			next.next = newHead;
			newHead = next;
			next = temp;
		}

		return newHead;
	}
}