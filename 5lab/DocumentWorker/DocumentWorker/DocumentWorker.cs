using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace DocumentWorker
{
    internal class DocumentWorker
    {
        public virtual string Pth
        {
            get;
            set;
        }
        public virtual void OpenDocument()
        {
            using (StreamReader streamReader = new StreamReader(Pth))
            {
                string text = streamReader.ReadToEnd();
                Console.WriteLine(text);
            }
            Console.WriteLine("Документ відкритий");

        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Правка документа доступна у версії Про");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Збереження документа доступне у версії Про");
        }

    }
}