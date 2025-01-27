using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_C_.LinkedList
{
    internal class CheckPallindromeinLL
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

        public static bool IsPalindrome(Node head)
        {
            if (head == null || head.Next == null)
                return true;

            // Find the middle of the linked list
            Node slow = head;
            Node fast = head;

            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
            }

            // Reverse the second half of the linked list
            Node reversedSecondHalf = ReverseLinkedList(slow);

            // Compare the first half and the reversed second half
            Node firstHalfPointer = head;
            Node secondHalfPointer = reversedSecondHalf;

            bool isPalindrome = true;
            while (secondHalfPointer != null)
            {
                if (firstHalfPointer.Data != secondHalfPointer.Data)
                {
                    isPalindrome = false;
                    break;
                }

                firstHalfPointer = firstHalfPointer.Next;
                secondHalfPointer = secondHalfPointer.Next;
            }

            // Restore the original structure of the linked list by reversing the second half back
            ReverseLinkedList(reversedSecondHalf);

            return isPalindrome;
        }

        public static void Main(string[] args)
        {
            // Create a sample linked list: 1 -> 2 -> 3 -> 2 -> 1 -> null
            Node head = new Node(1);
            head.Next = new Node(2);
            head.Next.Next = new Node(3);
            head.Next.Next.Next = new Node(2);
            head.Next.Next.Next.Next = new Node(1);

            Console.WriteLine("Original Linked List:");
            PrintLinkedList(head);

            // Check if the linked list is a palindrome
            bool result = IsPalindrome(head);

            Console.WriteLine($"Is the linked list a palindrome? {result}");
        }
    }
}
