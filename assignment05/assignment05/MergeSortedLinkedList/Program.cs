using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortedLinkedList;

namespace MergeSortedLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedLinkedList<int> n1 = new SortedLinkedList<int>("n1");
            n1.Insert(5);
            n1.Insert(4);
            n1.Insert(3);
            n1.Insert(6);
            n1.Insert(1);
            n1.Insert(2);
            n1.Display();

            SortedLinkedList<int> n2 = new SortedLinkedList<int>("n2");
            n2.Insert(0);
            n2.Insert(0);
            n2.Insert(9);
            n2.Insert(13);
            n2.Insert(-1);
            n2.Insert(7);
            n2.Display();

            SortedLinkedList<int> merged = Merger<int>.Merge<int>(ref n1, ref n2);
            merged.Display();
            Console.ReadKey();
        }
    }
}
