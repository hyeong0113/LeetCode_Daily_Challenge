public class Solution {
    // My solution:
    //      Runtime: faster than 95.63%
    //      Memory Usage: less than 7%
    // This is efficient in runtime since the runetime is O(n), but bad at memory usage since it uses Stack for convenience.
    public ListNode ReverseList(ListNode head) {
        ListNode current = head;
        Stack<int> valueStack = new Stack<int>();
        while(current != null)
        {
            valueStack.Push(current.val);
            current = current.next;
        }

        // I can improve this with checking head == null instead of checking size of s  tack
        if(valueStack.Count == 0)
        {
            return null;
        }
        
        ListNode reversed = new ListNode(valueStack.Pop());
        current = reversed;
        while(valueStack.Count != 0)
        {
            reversed.next = new ListNode(valueStack.Pop());
            reversed = reversed.next;
        }
        
        return current;
    }

    // Suggested solution:
    //      Runtime: faster than 48.57%
    //      Memory Usage: less than 89.63%
    // Less memory usage
    public class Solution {
    public ListNode ReverseList(ListNode head)
    {
        if (head == null) return head;

        ListNode prev = null;
        while (head != null)
        {
            ListNode next = head.next;
            head.next = prev;
            prev = head;
            head = next;
        }

        return prev;
    }
}
}