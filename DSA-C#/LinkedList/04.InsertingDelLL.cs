using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_C_.LinkedList
{
    public class InsertingDelLL
    {
        class Node
        {
            public int _data { get; set; }
            public Node _next { get; set; }

            public Node(int data,Node next) {
                _data = data;
                _next = next;
            }
            public Node(int data)
            {
                _data = data;
                _next = null;
            }

        }



    }
}
