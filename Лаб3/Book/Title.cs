using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Book
{
    internal class Title
    {
        private readonly string tit;
        public string TitleName
        {
            get { return tit; }
        }
        public Title(string title)
        {
            this.tit = title;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(tit);
        }
    }
}
