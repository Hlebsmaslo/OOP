using System;
using System.IO;

namespace DocumentWorker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:{Path.DirectorySeparatorChar}\Users{Path.DirectorySeparatorChar}quick{Path.DirectorySeparatorChar}Desktop{Path.DirectorySeparatorChar}Текстовий документ.txt";
            string line = " ";
            string extension = ".doc";
            int password = Convert.ToInt32(Console.ReadLine());
            int result = password % 3;
            switch (result)
            {
                case 0:
                    {
                        DocumentWorker worker = new DocumentWorker();
                        worker.Pth = path;
                        worker.OpenDocument();
                        worker.SaveDocument();
                        worker.EditDocument();
                        break;
                    }
                case 1:
                    {
                        ProDocumentWorker proworker = new ProDocumentWorker();
                        proworker.Pth = path;
                        proworker.Lne = line;
                        proworker.OpenDocument();
                        proworker.EditDocument();
                        proworker.SaveDocument();
                        break;
                    }
                case 2:
                    {
                        ExpertDocumentWorker expertDocumentWorker = new ExpertDocumentWorker();
                        expertDocumentWorker.Pth = path;
                        expertDocumentWorker.Lne = line;
                        expertDocumentWorker.Extension = extension;
                        expertDocumentWorker.OpenDocument();
                        expertDocumentWorker.EditDocument();
                        expertDocumentWorker.SaveDocument();
                        if (File.Exists(path))
                        {
                            Console.WriteLine("Ви можете видалити файл");
                            string askingAboutDelet = Console.ReadLine();
                            if (askingAboutDelet.ToLower() == "так")
                            {
                                File.Delete(path);
                            }
                            else
                            {
                                Console.WriteLine($"Файл не видалений");
                            }
                        }
                        break;
                    }
                default:
                    {
                        DocumentWorker worker = new DocumentWorker();
                        worker.Pth = path;
                        worker.OpenDocument();
                        worker.SaveDocument();
                        worker.EditDocument();
                        break;
                    }
            }
        }
    }
}