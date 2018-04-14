using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedLinkedList
{
    public class SortedLinkedList<T> where T : IComparable<T>
    {
        private ListNode<T> firstNode;
        private ListNode<T> lastNode;
        private string name;

        public SortedLinkedList(string listName)
        {
            name = listName;
            firstNode = lastNode = null;
        }

        public SortedLinkedList(): this( "list" ) {}

        public void Insert(T item)
        {
            Console.WriteLine(item);
            ListNode<T> newNode = new ListNode<T>(item);
            if (this.IsEmpty())
            {
                this.lastNode = newNode;
                this.firstNode = this.lastNode;
                return;
            }

            ListNode<T> current = firstNode;
            if (item.CompareTo(current.Data) == -1)
            {
                // Item is lesser than current node's value
                newNode.Next = current;
                this.lastNode.Next = newNode;
            }
            else
            {
                while (item.CompareTo(current.Data) == 1)
                {
                    // Item is greater than current node's value
                    current = current.Next;
                    Console.WriteLine("asd");
                }
                newNode.Next = current.Next;
                current.Next = newNode;
            }   
        }

        // Code below adapted from LinkedListLibrary by Deitel & Associates, Inc. and Pearson Education, Inc.
        public bool IsEmpty()
        {
            return firstNode == null;
        }

        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Empty {0}", name);
            }
            else
            {
                Console.Write("Contents of {0}: ", name);
                ListNode<T> current = firstNode;

                while (current != null)
                {
                    Console.Write(current.Data + " ");
                    current = current.Next;
                }
                Console.WriteLine("\n");
            }
        }

        public T RemoveFromFront()
        {
            if (IsEmpty())
                throw new EmptyListException(name);

            T removeItem = firstNode.Data;

            if (firstNode == lastNode)
                firstNode = lastNode = null;
            else
                firstNode = firstNode.Next;

            return removeItem;
        }

        public T RemoveFromBack()
        {
            if (IsEmpty())
                throw new EmptyListException(name);

            T removeItem = lastNode.Data;

            if (firstNode == lastNode)
                firstNode = lastNode = null;
            else
            {
                ListNode<T> current = firstNode;

                while (current.Next != lastNode)
                    current = current.Next;

                lastNode = current;
                current.Next = null;
            }

            return removeItem;
        }
    }
}
