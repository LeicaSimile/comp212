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
        private string name;

        public ListNode<T> FirstNode
        {
            get
            {
                return this.firstNode;
            }
        }

        public SortedLinkedList(string listName)
        {
            name = listName;
            firstNode = null;
        }

        public SortedLinkedList(): this( "list" ) {}

        public void Insert(T item)
        {
            ListNode<T> newNode = new ListNode<T>(item);
            if (this.IsEmpty())
            {
                this.firstNode = newNode;
                return;
            }

            ListNode<T> current = this.firstNode;
            ListNode<T> previous = current;
            do
            {
                switch (item.CompareTo(current.Data))
                {
                    case 0:
                    case -1:
                        if (current == this.firstNode)
                        {
                            this.firstNode = newNode;
                            newNode.Next = current;
                        }
                        else
                        {
                            previous.Next = newNode;
                            newNode.Next = current;
                        }
                        return;
                    case 1:
                        break;
                }
                previous = current;
                current = current.Next;
            } while (current.Next != null);

            if (item.CompareTo(current.Data) == -1)
            {
                previous.Next = newNode;
                newNode.Next = current;
            }
            else
            {
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
            firstNode = firstNode.Next;

            return removeItem;
        }
    }
}
