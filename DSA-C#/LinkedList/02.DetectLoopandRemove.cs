using System;

namespace DSA_C_.LinkedList
{
    public class DetectLoopandRemove
    {
        public class Node
        {
            public Node Next { get; set; }
            public int Data { get; set; }

            public Node(int data)
            {
                Data = data;
                Next = null;
            }
        }

        public class Solution
        {
            // Method to detect if a cycle exists and return the meeting point
            private Node GetMeetingPoint(Node head)
            {
                Node slow = head;
                Node fast = head;

                while (fast != null && fast.Next != null)
                {
                    slow = slow.Next;
                    fast = fast.Next.Next;

                    if (slow == fast)
                    {
                        return slow; // Cycle detected
                    }
                }

                return null; // No cycle
            }

            // Method to find the starting node of the cycle
            private Node FindStartOfCycle(Node head, Node meetingPoint)
            {
                Node slow = head;
                Node fast = meetingPoint;

                // Move slow and fast pointers one step at a time until they meet
                while (slow != fast)
                {
                    slow = slow.Next;
                    fast = fast.Next;
                }

                return slow; // Start of the cycle
            }

            // Method to remove the loop from the linked list
            private void RemoveLoop(Node head, Node loopNode)
            {
                Node slow = head;
                Node prev = null;

                // Find the node just before the start of the loop
                while (slow != loopNode)
                {
                    prev = loopNode;
                    slow = slow.Next;
                    loopNode = loopNode.Next;
                }

                // Break the loop
                if (prev != null)
                {
                    prev.Next = null;
                }
            }

            // Main method to detect and remove a loop
            public void DetectAndRemoveLoop(Node head)
            {
                if (head == null || head.Next == null)
                {
                    Console.WriteLine("No loop detected.");
                    return;
                }

                Node meetingPoint = GetMeetingPoint(head);

                if (meetingPoint != null)
                {
                    Console.WriteLine("Loop detected. Removing loop...");
                    RemoveLoop(head, meetingPoint);
                }
                else
                {
                    Console.WriteLine("No loop detected.");
                }
            }
        }

        public static void PrintLinkedList(Node head)
        {
            Node current = head;

            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }

            Console.WriteLine("null");
        }

        public static void Main(string[] args)
        {
            // Create a linked list with a loop: 1 -> 2 -> 3 -> 4 -> 5 -> (back to 3)
            Node head = new Node(1);
            head.Next = new Node(2);
            head.Next.Next = new Node(3);
            head.Next.Next.Next = new Node(4);
            head.Next.Next.Next.Next = new Node(5);
            head.Next.Next.Next.Next.Next = head.Next.Next; // Create a loop

            Solution solution = new Solution();

            // Detect and remove the loop
            solution.DetectAndRemoveLoop(head);

            // Print the list after removing the loop
            Console.WriteLine("Linked list after removing the loop:");
            PrintLinkedList(head);
        }
    }
}
// alternate easy approach
 //detect a loop and find sarting node and remove 
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
//public class Solution
//{
//    public ListNode DetectCycle(ListNode head)
//    {
//        ListNode slow = head;
//        ListNode fast = head;
//        bool isCycle = false;
//        if (head == null || head.next == null)
//        {
//            return null;
//        }
//        while (fast != null && fast.next != null)
//        {
//            slow = slow.next;
//            fast = fast.next.next;
//            if (slow == fast)
//            {
//                isCycle = true;
//                break;
//            }
//        }
//        if (!isCycle)
//        {
//            return null;
//        }
//        slow = head;
//        ListNode prev = null;
//        while (slow != fast)
//        {
//            slow = slow.next;
//            prev = fast;
//            fast = fast.next;
//        }
//        prev = prev.next;
//        return slow;





//    }
//}