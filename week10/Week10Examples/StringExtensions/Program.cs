using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "is it cool that i said all that?";
            Console.WriteLine(s.StartCase());
            Console.ReadKey();
        }
    }
}
