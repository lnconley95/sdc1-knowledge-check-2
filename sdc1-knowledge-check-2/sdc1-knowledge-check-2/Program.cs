using sdc1_knowledge_check_2;
using System;
using System.Collections.Generic;

namespace YourNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("How many Fiction books do you want to add? ");
                var numberOfBooks = int.Parse(Console.ReadLine());

                var bookList = new List<FictionBook>();
                for (int i = 0; i < numberOfBooks; i++)
                {
                    var fictionBook = new FictionBook();

                    Console.WriteLine("Enter the title of the Book: ");
                    fictionBook.Title = Console.ReadLine();

                    Console.WriteLine("Enter the Author of the Book: ");
                    fictionBook.Author = Console.ReadLine();

                    Console.WriteLine("Enter the number of Pages in the Book: ");
                    fictionBook.NumberOfPages = int.Parse(Console.ReadLine());

                    bookList.Add(fictionBook);
                }

                foreach (var book in bookList)
                {
                    Console.WriteLine("Book Title: " + book.Title);
                    Console.WriteLine("Author: " + book.Author);
                    Console.WriteLine("Number of Pages: " + book.NumberOfPages);
                }

                Console.ReadLine();
            }
        }
    }
}
