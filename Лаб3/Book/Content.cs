using System;
using System.Collections.Generic;
using System.Text;

namespace Book
{
    internal class Content
    {
        private string con;
        public string Сontents
        {
            get { return con; }
        }

        public Content(string context)
        {
            this.con = context;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(con);
        }
    }
}
