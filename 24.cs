/*
24. Swap Nodes in Pairs •Difficulty: Easy
Given a linked list, swap every two adjacent nodes and return its head. 

For example,
 Given 1->2->3->4, you should return the list as 2->1->4->3. 

Your algorithm should use only constant space. 
You may not modify the values in the list, only nodes itself can be changed. 
*/

public class Solution {
    public ListNode SwapPairs(ListNode head) {
        ListNode res=new ListNode(0);
        ListNode p=res;
        p.next=head;
        while(p.next!=null&&p.next.next!=null)
        {
            //0         1 2 3 4
           ListNode l1=p;      //0
           p=p.next;//Move to head //1
           l1.next=p.next;//l1 linked to 2nd node   //2
           
           ListNode l2=p.next.next; //3
           p.next.next=p; //2->1
           p.next=l2; //1->3            
            
        }
        return res.next;
    }
}

//Python 
/*
# Definition for singly-linked list.
# class ListNode(object):
#     def __init__(self, x):
#         self.val = x
#         self.next = None

class Solution(object):
    def swapPairs(self, head):
        """
        :type head: ListNode
        :rtype: ListNode
        """
        dummy=prev=ListNode(0)
        prev.next=head
        while head and head.next:
            head.next.next,head.next,prev.next,prev,head=head,head.next.next,head.next,head,head.next.next
        return dummy.next
*/