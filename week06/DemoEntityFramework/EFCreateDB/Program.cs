using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCreateDB
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new BloggingContext();
            Console.Write("Please enter a name for a new blog:");

            var name = Console.ReadLine();
            var blog = new Blog { Name = name };
            db.Blogs.Add(blog); //insert a new row to the table Blogs
            db.SaveChanges();  // save the change to the underlying database

            var query = from b in db.Blogs
                        select b;
            Console.WriteLine("All blogs in table Blogs");
            foreach (var row in query)
                Console.WriteLine(row.Name);

            Console.ReadKey();

        }
    }
}
