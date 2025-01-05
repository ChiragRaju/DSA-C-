using System;

namespace DSA.LinkedList
{
    internal class ReverseLL
    {
        public class Node
        {
            public Node Next { get; set; }
            public int Data { get; set; }

            // Constructor to initialize node with next and data
            public Node(Node next, int data)
            {
                Next = next;
                Data = data;
            }

            // Constructor to initialize node with data only
            public Node(int data)
            {
                Data = data;
                Next = null;
            }
        }

        public static Node ReverseLinkedList(Node head)
        {
            if (head == null)
            {
                Console.WriteLine("The linked list is empty.");
                return null;
            }

            Node prev = null;
            Node current = head;

            while (current != null)
            {
                // Save the next node
                Node nextNode = current.Next;

                // Reverse the pointer of the current node
                current.Next = prev;

                // Move prev and current one step forward
                prev = current;
                current = nextNode;
            }

            return prev; // New head of the reversed list
        }

        public static void PrintLinkedList(Node head)
        {
            if (head == null)
            {
                Console.WriteLine("The linked list is empty.");
                return;
            }

            Node temp = head;

            while (temp != null)
            {
                Console.Write(temp.Data + " -> ");
                temp = temp.Next;
            }

            Console.WriteLine("null");
        }

        public static void Main(string[] args)
        {
            // Create a sample linked list: 1 -> 2 -> 3 -> 4 -> null
            Node head = new Node(1);
            head.Next = new Node(2);
            head.Next.Next = new Node(3);
            head.Next.Next.Next = new Node(4);

            Console.WriteLine("Original Linked List:");
            PrintLinkedList(head);

            // Reverse the linked list
            Node reversedHead = ReverseLinkedList(head);

            Console.WriteLine("Reversed Linked List:");
            PrintLinkedList(reversedHead);
        }
    }
}
