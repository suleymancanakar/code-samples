/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        
        if (head == null)
        {
            return null;
        }
        ListNode current = head;
        ListNode fast = head;
        for (int i = 0; i < n ; i++)
        {
            fast = fast.next;
        }
        while (fast != null && fast.next != null)
        {
           current = current.next;
           fast = fast.next;
        }
        if (fast == null)
        {
            head = current.next;
            return head;
        }
        if (current.next == null)
        {
            return null;
        }
        if (current.next != null && current.next.next == null)
        {
            current.next  = null;
        }
        else
        {
            current.next  = current.next.next;
        }
        return head;
    }
}