using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_C_.LinkedList
{
    internal class FindNthDeleteNthNodeLL
    {
        public class Node
        {
            public Node Next { get; set; }
            public int Data { get; set; }
            public Node(Node next, int data)
            {
                Next = next;
                Data = data;
            }
            public Node(int data)
            {
                Next = null; Data = data;
            }


        }

        //public static Node FindNthNode(Node head,int n)
        //{

        //    Node fast= head;
        //    Node slow= head;
        //    for(int i=0;i<n;i++)
        //    {

        //         fast= fast.Next;
        //    }
        //    if(fast==null)
        //    {
        //        return null;
        //    }
        //    while (fast != null)
        //    {
        //        slow = slow.Next;
        //        fast = fast.Next;
        //    }
        //    return slow;
        //}
        public static Node DeleteNthNode(Node head, int n)
        {

            Node fast = head;
            Node slow = head;
            for (int i = 0; i < n; i++)
            {

                fast = fast.Next;
            }
            if (fast == null)
            {
                return null;
            }
            while (fast != null)
            {
                slow = slow.Next;
                fast = fast.Next;
            }
            Node delNode = slow.Next;
            slow.Next = slow.Next.Next;
            delNode = null;
            return head;
        }

        private static void PrintLL(Node head)
        {
            while (head != null)
            {
                Console.WriteLine(head.Data);
                head = head.Next;
            }
        }
        public static void Main(string[] args)
        {
            int[] arr = { 2, 4, 5, 6, 7 };
            int N = 3;
            var head = new Node(arr[0]);
            head.Next = new Node(arr[1]);
            head.Next = new Node(arr[2]);
            head.Next = new Node(arr[3]);
            head.Next = new Node(arr[4]);

            head = DeleteNthNode(head, N);
            PrintLL(head);



        }
    }
}
