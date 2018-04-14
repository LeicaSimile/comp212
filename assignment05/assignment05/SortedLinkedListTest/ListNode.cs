using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortedLinkedList
{
    public class ListNode<T> where T : IComparable<T>
    {
        public T Data { get; private set; }

        public ListNode<T> Next { get; set; }

        public ListNode(T dataValue): this(dataValue, null){}
      
        public ListNode(T dataValue, ListNode<T> nextNode)
        {
            Data = dataValue;
            Next = nextNode;
        }
    }
}
