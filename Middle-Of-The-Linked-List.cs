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
    public ListNode MiddleNode(ListNode head) {
        ListNode slow = head, fast = head;
// finind the mid node of the linked list
while (fast != null && fast.next != null)
{
    fast = fast.next.next;
    slow = slow.next; //the mid of LL
}
return slow;
    }
}
