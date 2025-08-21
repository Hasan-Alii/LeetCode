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
    public ListNode SwapNodes(ListNode head, int k) {
         ListNode first = head, second = head;
 for (int i = 1; i < k; i++)
 {
     first = first.next;
 }
 ListNode last = first;
 while(last.next != null)
 {
     last = last.next;
     second = second.next;
 }
 // Swap the values of the two nodes
 int temp = first.val;
 first.val = second.val;
 second.val = temp;
 return head;
    }
}
