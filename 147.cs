/* 147. Insertion Sort List

    Total Accepted: 86153
    Total Submissions: 274984
    Difficulty: Medium
    Contributors: Admin

Sort a linked list using insertion sort.
*/
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution
{
    public ListNode InsertionSortList(ListNode head)
    {
        if (head == null)
        {
            return head;
        }

        ListNode helper = new ListNode(0); //new starter of the sorted list
        ListNode cur = head; //the node will be inserted
        ListNode pre = helper; //insert node between pre and pre.next
        ListNode next = null; //the next node will be inserted
                              //not the end of input list
        while (cur != null)
        {
            next = cur.next;
            //find the right place to insert
            while (pre.next != null && pre.next.val < cur.val)
            {
                pre = pre.next;
            }
            //insert between pre and pre.next
            cur.next = pre.next;
            pre.next = cur;
            pre = helper;
            cur = next;
        }

        return helper.next;
    }
}