using System;

namespace DSA_C_.LinkedList
{
    internal class MiddleOfLLcs
    {
        // Tortoise and Hare Algorithm to find the middle of a linked list

        public class Node
        {
            public int Data { get; set; }
            public Node Next { get; set; }

            public Node(int data)
            {
                Data = data;
                Next = null;
            }

            public Node(int data, Node next)
            {
                Data = data;
                Next = next;
            }
        }

        public class LinkedListOperations
        {
            // Method to find the middle of the linked list
            public static Node FindMiddle(Node head)
            {
                if (head == null)
                    return null;

                Node slow = head;
                Node fast = head;

                while (fast != null && fast.Next != null)
                {
                    slow = slow.Next;
                    fast = fast.Next.Next;
                }

                return slow;
            }
        }

        // Example usage
        public static void Main(string[] args)
        {
            Node head = new Node(1);
            head.Next = new Node(2);
            head.Next.Next = new Node(3);
            head.Next.Next.Next = new Node(4);
            head.Next.Next.Next.Next = new Node(5);

            Node middle = LinkedListOperations.FindMiddle(head);
            if (middle != null)
            {
                Console.WriteLine($"The middle node value is: {middle.Data}");
            }
            else
            {
                Console.WriteLine("The linked list is empty.");
            }
        }
    }
}
