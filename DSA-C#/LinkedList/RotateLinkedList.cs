using System;

namespace DSA_C_.LinkedList
{
    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }

        public Node(int data, Node next = null)
        {
            Data = data;
            Next = next;
        }
    }

    public class RotateLinkedList
    {
        public static Node RotateLL(Node head, int k)
        {
            if (head == null || head.Next == null || k == 0)
            {
                return head;
            }

            // Find length and last node
            Node tail = head;
            int length = 1;
            while (tail.Next != null)
            {
                tail = tail.Next;
                length++;
            }

            // Reduce k if greater than length
            k = k % length;
            if (k == 0)
            {
                return head;
            }

            // Make it circular
            tail.Next = head;

            // Find new tail
            Node newTail = tail;
            for (int i = 0; i < length - k; i++)
            {
                newTail = newTail.Next;
            }

            // Break the circle
            Node newHead = newTail.Next;
            newTail.Next = null;

            return newHead;
        }

        public static void PrintList(Node head)
        {
            while (head != null)
            {
                Console.Write(head.Data + " -> ");
                head = head.Next;
            }
            Console.WriteLine("null");
        }

        public static void Main(string[] args)
        {
            // Creating list: 1 -> 2 -> 3 -> 4 -> 5
            Node head = new Node(1);
            head.Next = new Node(2);
            head.Next.Next = new Node(3);
            head.Next.Next.Next = new Node(4);
            head.Next.Next.Next.Next = new Node(5);

            Console.WriteLine("Original List:");
            PrintList(head);

            int k = 2;
            Node rotated = RotateLL(head, k);

            Console.WriteLine($"\nRotated List by {k} positions:");
            PrintList(rotated);
        }
    }
}
