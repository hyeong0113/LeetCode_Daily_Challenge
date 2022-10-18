public class Solution {
    // My solution:
    //      Runtime: faster than 32.49%
    //      Memory Usage: less than 40.25%

    // There is a better solution using recursive
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        if(list1 == null && list2 == null)
        {
            return null;
        }

        ListNode curr1 = list1;
        ListNode curr2 = list2;

        List<int> valueList = new List<int>();
        while(curr1 != null)
        {
            valueList.Add(curr1.val);
            curr1 = curr1.next;
        }
        
        while(curr2 != null)
        {
            valueList.Add(curr2.val);
            curr2 = curr2.next;
        }
        
        valueList.Sort();
        
        ListNode result = new ListNode(valueList[0]);
        ListNode curr = result;
        for(int i = 1; i < valueList.Count; i++)
        {
            curr.next = new ListNode(valueList[i]);
            curr = curr.next;
        }
        return result;
    }
}
