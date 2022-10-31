using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DocumentWorker
{
    internal class ProDocumentWorker : DocumentWorker
    {
        public override string Pth { get => base.Pth; set => base.Pth = value; }
        public virtual string Lne
        {
            get;
            set;
        }
        public override void OpenDocument()
        {
            base.OpenDocument();
        }

        public override async void EditDocument()
        {
            Console.WriteLine("Документ був відредагований");
            using (StreamWriter a = new StreamWriter(Pth, true))
            {
                await a.WriteLineAsync(Lne);
            }
            this.OpenDocument();
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Документ зберiгся у старому форматі");
        }
    }
}