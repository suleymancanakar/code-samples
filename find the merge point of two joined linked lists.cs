

    // Complete the findMergeNode function below.

    /*
     * For your reference:
     *
     * SinglyLinkedListNode {
     *     int data;
     *     SinglyLinkedListNode next;
     * }
     *
     */
    static int findMergeNode(SinglyLinkedListNode head1, SinglyLinkedListNode head2) {

            if (head1 == null || head2 == null)
            {
                return -1;
            }
            SinglyLinkedListNode current1 = head1;          
            while(current1 != null)
            {
                SinglyLinkedListNode current2 = head2;
                while (current2 != null)
                {
                    if (current1.data == current2.data)
                    {
                        SinglyLinkedListNode temp1 = current1.next;
                        SinglyLinkedListNode temp2 = current2.next;
                        while (temp1 != null && temp2 != null)
                        {
                            if (temp1.data == temp2.data)
                            {
                                temp1 = temp1.next;
                                temp2 = temp2.next;
                            }
                            else
                            {
                                break;
                            }
                        }
                        if (temp1 == null && temp2 == null)
                        {
                            return current2.data;
                        }
                    }
                    current2 = current2.next;
                }
                current1 = current1.next;
            }
            return -1;
    }

