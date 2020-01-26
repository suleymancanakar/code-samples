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
            if (l1 == null || l2 == null)
            {
                return null;
            }
            ListNode totalNode = new ListNode(0);
            ListNode head = totalNode;
            int sum = 0;
            while(l1 != null || l2 != null)
            {
                int toplam = 0;
                int deger = 0;
                if (l1 != null && l2 != null)
                {
                    toplam = l1.val + l2.val + sum;
                    l1 = l1.next;
                    l2 = l2.next;
                }
                else if(l1 != null)
                {
                    toplam = l1.val + sum;
                    l1 = l1.next;
                }
                else if (l2 != null)
                {
                    toplam = l2.val + sum;
                    l2 = l2.next;
                }

                sum = toplam >= 10 ? 1 : 0;
                deger = toplam % 10;
                totalNode.next = new ListNode(deger);
                totalNode = totalNode.next;
            }
            if (sum == 1)
            {
                totalNode.next = new ListNode(1);
            }
            head = head.next;
            return head;
    }
}