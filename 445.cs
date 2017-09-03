/*
 445. Add Two Numbers II

    Total Accepted: 1002
    Total Submissions: 2451
    Difficulty: Medium
    Contributors: Admin

You are given two linked lists representing two non-negative numbers. The most significant digit comes first and each of their nodes contain a single digit. Add the two numbers and return it as a linked list.

You may assume the two numbers do not contain any leading zero, except the number 0 itself.

Follow up:
What if you cannot modify the input lists? In other words, reversing the lists is not allowed.

Example:

Input: (7 -> 2 -> 4 -> 3) + (5 -> 6 -> 4)
Output: 7 -> 8 -> 0 -> 7
*/
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
		ListNode node = new ListNode(0);
		ListNode res = node;
		Stack<ListNode> resStack = new Stack<ListNode>();
		//initiate stack collection to store l1&l2 int numbers.
        Stack<int> l1Stack = new Stack<int>();
		Stack<int> l2Stack = new Stack<int>();
		while(l1!= null)
		{
			l1Stack.Push(l1.val);
			l1 = l1.next;
		}

		while(l2!= null)
		{
			l2Stack.Push(l2.val);
			l2 = l2.next;
		}

		//set variable counter
        int counter = 0;

		while(l1Stack.Count>0||l2Stack.Count>0)
		{
			int result = 0;
			result+= counter;
			if(l1Stack.Count == 0)
			{
				result+= l2Stack.Pop();
			}
			else
				if(l2Stack.Count == 0)
			{
				result+= l1Stack.Pop();
			}
			else
			{
				result+= l1Stack.Pop()+l2Stack.Pop();
			}

			counter = result>= 10?1:0;
			result%= 10;
			//Console.WriteLine("result:"+result +" counter:"+counter);
			resStack.Push(new ListNode(result));
		}

		if(counter == 1) {
			resStack.Push(new ListNode(1));
		}

		while(resStack.Count>0)
		{
			node.next = resStack.Pop();
			node = node.next;
		}

		return res.next;
	}
}