using System;
using System.Collections.Generic;
using System.Text;

namespace Book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Назва книги - ");
            string title = Console.ReadLine();
            Console.Write("Автор книги - ");
            string author = Console.ReadLine();
            Console.WriteLine("Вмiст книги -  ");
            string content = Console.ReadLine();
            Book book = new Book(new Title(title), new Author(author), new Content(content));
            Console.WriteLine();
            Console.Clear();
            book.Title.Show();
            book.Author.Show();
            book.Content.Show();
            Console.WriteLine();
        }

        
    }
}
