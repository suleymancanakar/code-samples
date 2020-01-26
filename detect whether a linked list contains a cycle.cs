

    // Complete the hasCycle function below.

    /*
     * For your reference:
     *
     * SinglyLinkedListNode {
     *     int data;
     *     SinglyLinkedListNode next;
     * }
     *
     */
    static bool hasCycle(SinglyLinkedListNode head) {

            SinglyLinkedListNode slow = head;
            SinglyLinkedListNode fast = head;

            while(fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (fast == null)
                {
                    return false;
                }
                if (slow == fast)
                {
                    return true;
                }
            }
            return false;
    }

