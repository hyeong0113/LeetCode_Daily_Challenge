// Intuition
// First of all, usin stack was my first thought for this problem. If stack is used, it can simply push values, then pop them.

// Approach
// As mentioned above, stack is used to store values in the linked list. After that, create a head of new linkedlist with the topmost value in the stack. Then, run while loop create other nodes with the remained values.

// Complexity
// Time complexity:
// 92.53% better performance than average performance. Time complexity is O(n) since two while loop iterates n times, which is size of the linkedlist.

// Space complexity:
// 6.85% better performance thatn average performance. Space complexity is O(n) since stack stores n values from the linked list, then create n new nodes for the reversed linkedlist.

// Code
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode ReverseList(ListNode head) {
        if(head == null)
        {
            return null;
        }
        Stack<int> nodeStack = new Stack<int>();
        ListNode current = head;

        while(current != null)
        {
            nodeStack.Push(current.val);
            current = current.next;
        }

        ListNode newHead = new ListNode(nodeStack.Pop());
        current = newHead;
        while(nodeStack.Count > 0)
        {
            current.next = new ListNode(nodeStack.Pop());
            current = current.next;
        }

        return newHead;
    }
}