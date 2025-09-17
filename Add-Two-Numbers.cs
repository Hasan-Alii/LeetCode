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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode resultList = new ListNode();
        ListNode result = resultList;
        int res = 0, l1Val = 0, l2Val = 0, rem = 0;
        while (l1 != null || l2 != null || rem != 0)
        {
            if (l1 == null)
                l1Val = 0;
            else
                l1Val = l1.val;
            if (l2 == null)
                l2Val = 0;
            else
                l2Val = l2.val;

            res = l1Val + l2Val + rem;
            rem = res / 10;
            result.next = new ListNode(res%10);
            result = result.next;
            if (l1 != null) l1 = l1.next;
            if (l2 != null) l2 = l2.next;
        }
        return resultList.next;
    }
}
