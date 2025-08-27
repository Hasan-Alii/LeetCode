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
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
                ListNode list = new ListNode();
        ListNode nl = list;
        while (l1 != null && l2 != null)
        {
            if (l1.val < l2.val)
            {
                nl.next = l1;
                l1 = l1.next;
            }
            else
            {
                nl.next = l2;
                l2 = l2.next;
            }
            nl = nl.next;
        }
        if (l1 != null)
            nl.next = l1;
        if (l2 != null)
            nl.next = l2;
        GC.Collect();
        return list.next;
    }
}
