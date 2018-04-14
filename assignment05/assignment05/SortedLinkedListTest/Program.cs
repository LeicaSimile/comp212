using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortedLinkedList;

// Angelica Catalan, 300846458
namespace SortedLinkedListTest
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedLinkedList<string> sortme = new SortedLinkedList<string>("Names");
            sortme.Insert("Elsa");
            sortme.Insert("Anna");
            sortme.Insert("Kristoff");
            sortme.Insert("Hans");
            sortme.Insert("Olaf");
            sortme.Display();
            Console.ReadKey();

            SortedLinkedList<int> sortmetoo = new SortedLinkedList<int>("Numbers");
            sortmetoo.Insert(5);
            sortmetoo.Insert(4);
            sortmetoo.Insert(3);
            sortmetoo.Insert(6);
            sortmetoo.Insert(1);
            sortmetoo.Insert(2);
            sortmetoo.Display();
            Console.ReadKey();
        }
    }
}
