/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode SwapPairs(ListNode head) {

            if (head == null)
            {
                return null;
            }
            if (head.next == null)
            {
                return head;
            }
            ListNode current = head;
            int index = 1;
            List<ListNode> list1 = new List<ListNode>();
            List<ListNode> list2 = new List<ListNode>();

            while(current != null)
            {
                ListNode item = new ListNode(current.val);
                if (index % 2 == 0)
                {
                    list1.Add(item);
                }
                else
                {
                    list2.Add(item);
                }
                current = current.next;
                index++;
            }
            int list1Length = list1.Count;
            int list2Length = list2.Count;
            int i = 0;
            int j = 0;

            ListNode first = new ListNode(int.MinValue);
            ListNode temp = first;
            while(i < list1Length && j < list2Length)
            {
                temp.next = list1[i];
                temp.next.next = list2[j];

                i++;
                j++;
                temp = temp.next.next;
            }
            while(i < list1Length)
            {
                temp.next = list1[i];
                i++;
            }
            while (j < list2Length)
            {
                temp.next = list2[j];
                j++;
            }
            first = first.next;
            return first;
    }
}