/*
21. Merge Two Sorted Lists •Difficulty: Easy
Merge two sorted linked lists and return it as a new list. 
The new list should be made by splicing together 
the nodes of the first two lists.
*/
public class Solution
{
    public ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
        if (l1 == null) return l2;
        if (l2 == null) return l1;

        ListNode res = new ListNode(0);
        ListNode n = res;

        while (l1 != null || l2 != null)
        {
            if (l1 == null)
            {
                res.next = l2;
                break;
            }
            if (l2 == null)
            {
                res.next = l1;
                break;
            }
            if (l1.val < l2.val)
            {
                res.next = l1;
                l1 = l1.next;
            }
            else
            {
                res.next = l2;
                l2 = l2.next;
            }
            res = res.next;
        }
        return n.next;
    }
}