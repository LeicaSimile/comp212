using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    class SimpleDelegate
    {
        public delegate void Del(string message);

        static void Main(string[] args)
        {
            Del handler = DelegateMethod;
            Del handler2 = DelegateMethod2;

            handler("Is it cool that I said all that?");
            handler2.Invoke("'cause I know that it's delegate.");

            Console.ReadKey();
        }

        public static void DelegateMethod(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("Is it too soon to do this yet?");
        }

        public static void DelegateMethod2(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("Isn't it isn't it isn't it");
        }
    }
}
