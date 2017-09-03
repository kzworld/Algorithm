/*
141. Linked List Cycle •Difficulty: Easy
Given a linked list, determine if it has a cycle in it. 
Follow up:
 Can you solve it without using extra space? 
*/

/*
C#
*/
public class Solution {
    public bool HasCycle(ListNode head) {
        if(head==null) return false;
        ListNode slow= head;
        ListNode fast=head;
        while(fast.next!=null&&fast.next.next!=null)
        {
            slow=slow.next;
            fast=fast.next.next;
            if(slow==fast) return true;
        }
        return false;
    }
}

/*
Javascript
*/
var hasCycle = function(head) {
    if(head==null) return false;
    slow=head;
    fast=head;
    while(fast.next!==null&&fast.next.next!==null)
    {
        slow=slow.next;
        fast=fast.next.next;
        if(slow==fast) return true;
    }
    return false;
};



