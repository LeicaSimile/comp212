using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortedLinkedList;


namespace SortedLinkedListTest
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedLinkedList<string> sortme = new SortedLinkedList<string>("Names");
            sortme.Insert("Elsa");
            sortme.Insert("Anna");
            sortme.Display();
            Console.ReadKey();
        }
    }
}
