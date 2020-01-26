

    // Complete the insertNodeAtTail function below.

    /*
     * For your reference:
     *
     * SinglyLinkedListNode {
     *     int data;
     *     SinglyLinkedListNode next;
     * }
     *
     */
    static SinglyLinkedListNode insertNodeAtTail(SinglyLinkedListNode head, int data) {

        SinglyLinkedListNode newNode  = new SinglyLinkedListNode(data);
        if (head == null)
        {
            head = newNode;
            newNode.next = null;
            return head;
        }
        SinglyLinkedListNode current = head;
        while(current != null && current.next != null)
        {
            current = current.next;
        }
        current.next = newNode;
        newNode.next = null;

       /* current = head;
        while (current != null)
        {
            Console.WriteLine(current.data + " ");
            current = current.next;
        }*/

        return head;
    }

