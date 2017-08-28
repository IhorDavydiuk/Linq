using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlLinq
{
    class Book
    {
        public string Author { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
    }
    static class ControlLinq
    {
        public static void Print()
        {
            Console.WriteLine("Task 1");
            List<Book> books = new List<Book> {
            new Book { Name = "Programming Microsoft LINQ", Year = 2012 } ,
            new Book { Name = "Head First C#", Year = 2000 },
            new Book { Name = "C# 6.0 in a Nutshell", Year = 2002 }
        };

            foreach (var item in books.Where(c => (c.Name.ToUpper().Contains("LINQ") && ((c.Year % 4 == 0 && c.Year % 100 != 0) || (c.Year % 400 == 0)))))
            {
                Console.WriteLine(item.Name + " " + item.Year);
            }
            Console.WriteLine();

            Console.WriteLine("Task 2");
            List<string> words = new List<string> { "qw", "we", "er" };
            Console.WriteLine((string.Concat("", new string(words.SelectMany(c => c).ToArray())).ToUpper().Distinct().Count()));
            Console.WriteLine();

            Console.WriteLine("Task 3");
            int[] masInt = {14,12,23,20,33,32 };
            foreach (var item in masInt.OrderBy(c=>c.ToString()[0]).ThenByDescending(v=>v.ToString()[1]))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("Task 4");
            List<Book> books2 = new List<Book> {
            new Book { Name = "Programming Microsoft LINQ", Author = "Paolo Pialorsi" } ,
            new Book { Name = "Programming ", Author = "Paolo Pialorsi" } ,
            new Book { Name = "Head First C#", Author = "Jennifer Greene" },
            new Book { Name = "C# 6.0 in a Nutshell", Author = "Joseph Albahari" }
            };
            foreach (var items in books2.GroupBy(c=>c.Author))
            {
                Console.WriteLine(items.Key + " " + items.Count());
            }
            Console.WriteLine();

        } 
    }
}
