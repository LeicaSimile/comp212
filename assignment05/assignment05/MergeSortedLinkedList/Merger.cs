using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortedLinkedList;

// Angelica Catalan, 300846458
namespace MergeSortedLinkedList
{
    class Merger<T> where T : IComparable<T>
    {
        public static SortedLinkedList<T> Merge<T>(ref SortedLinkedList<T> a, ref SortedLinkedList<T> b) where T : IComparable<T>
        {
            SortedLinkedList<T> merged = a;
            ListNode<T> current = b.FirstNode;
            if (b.IsEmpty())
            {
                return merged;
            }

            do
            {
                merged.Insert(current.Data);
                current = current.Next;
            } while (current.Next != null);
            merged.Insert(current.Data);

            return merged;
        }
    }
}
