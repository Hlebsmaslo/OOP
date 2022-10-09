using System;
using System.Collections.Generic;
using System.Text;

namespace Book
{
    internal class Author
    {
        private readonly string wri;

        public Author(string writer)
        {
            this.wri = writer;
        }


        public string Writer
        {
            get { return wri; }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(wri);
        }
    }
}
