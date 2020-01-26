

    // Complete the removeDuplicates function below.

    /*
     * For your reference:
     *
     * SinglyLinkedListNode {
     *     int data;
     *     SinglyLinkedListNode next;
     * }
     *
     */
    static SinglyLinkedListNode removeDuplicates(SinglyLinkedListNode head) {

            if (head == null)
            {
                return null;
            }
            SinglyLinkedListNode current = head;
            while (current != null && current.next != null)
            {
                if (current.data == current.next.data)
                {
                    while ((current != null && current.next != null) && (current.data == current.next.data))
                    {
                        current.next = current.next.next;
                    }
                }
                current = current.next;
            }
            return head;
    }

