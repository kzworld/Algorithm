/*
83. Remove Duplicates from Sorted List •Difficulty: Easy
Given a sorted linked list, delete all duplicates such that each element appear only once. 

For example,
 Given 1->1->2, return 1->2.
 Given 1->1->2->3->3, return 1->2->3. 
*/
public class Solution
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        ListNode p = head;
        ListNode q = p;

        while (p != null && p.next != null)
        {
            if (p.val == p.next.val)
                p.next = p.next.next;
            else //In case, there're multiple duplicates following nodes.[1,1,1] so use (else) 
                p = p.next;
        }
        return q;
    }
}