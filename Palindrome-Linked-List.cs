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
    public bool IsPalindrome(ListNode head) {
                ListNode slow = head, fast = head;
        // finind the mid node of the linked list
        while (fast != null && fast.next != null)
        {
            fast = fast.next.next;
            slow = slow.next; //the mid of LL
        }

        // reversing the second half of the linked list
        ListNode prev = null, temp;
        while (slow != null)
        {
            temp = slow.next;
            slow.next = prev;
            prev = slow; // the pointer to first node of the reversed second half
            slow = temp;
        }

        // Comparing fisrt & second halves of the linked list
        while(prev != null)
        {
            if (prev.val != head.val)
                return false;
            prev = prev.next;
            head = head.next;
        }
        return true;
    }
}
