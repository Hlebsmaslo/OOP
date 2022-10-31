using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace DocumentWorker
{
    internal class ExpertDocumentWorker : ProDocumentWorker
    {
        public override string Pth { get => base.Pth; set => base.Pth = value; }
        public override string Lne { get => base.Lne; set => base.Lne = value; }
        public virtual string Extension { get; set; }
        public override void OpenDocument()
        {
            base.OpenDocument();
        }
        public override void EditDocument()
        {
            base.EditDocument();
        }
        public override void SaveDocument()
        {
            string currentExtension = System.IO.Path.GetExtension(Pth);
            Console.WriteLine($"Минуле розширення файлу {currentExtension}");
            string newPath = System.IO.Path.ChangeExtension(Pth, Extension);
            using (StreamReader streamReader = new StreamReader(Pth))
            {
                string text = streamReader.ReadToEnd();
                using (StreamWriter sw = new StreamWriter(newPath))
                {
                    sw.WriteLine(text);
                }
            }
            Console.WriteLine("Документ збережений в новому форматі");
            string newExtension = System.IO.Path.GetExtension(newPath);
            Console.WriteLine($"Розширення файлу - {newExtension}");
        }
    }
}