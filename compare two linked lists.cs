

    // Complete the CompareLists function below.

    /*
     * For your reference:
     *
     * SinglyLinkedListNode {
     *     int data;
     *     SinglyLinkedListNode next;
     * }
     *
     */
    static bool CompareLists(SinglyLinkedListNode head1, SinglyLinkedListNode head2) {

            if (head1 == null && head2 == null)
            {
                return true;
            }

            SinglyLinkedListNode current1 = head1;
            SinglyLinkedListNode current2 = head2;

            while ((current1 != null) || (current2 != null))
            {
                if (current1 == null && current2 != null)
                {
                    return false;
                }
                if (current1 != null && current2 == null)
                {
                    return false;
                }
                if (current1.data != current2.data)
                {
                    return false;
                }
                current1 = current1.next;
                current2 = current2.next;
            }
            return true;
    }

