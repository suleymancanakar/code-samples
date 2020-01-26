

    // Complete the insertNodeAtPosition function below.

    /*
     * For your reference:
     *
     * SinglyLinkedListNode {
     *     int data;
     *     SinglyLinkedListNode next;
     * }
     *
     */
    static SinglyLinkedListNode insertNodeAtPosition(SinglyLinkedListNode head, int data, int position) {

        if (head == null)
        {
            return null;
        }
        int index = 1;

        SinglyLinkedListNode current = head;
        while(index != position)
        {
            current = current.next;
            index++;
        }
        SinglyLinkedListNode newNode = new SinglyLinkedListNode(data);
        newNode.next = current.next;
        current.next = newNode;

        return head;
    }

