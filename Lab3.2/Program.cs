using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System;
using System.Text.Json;
using Lab3._2;
using System.Linq;

namespace Lav3._2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string pd = @"path";
            Func<Class1, bool> fil = p => p.Price > 50;
            for (int i = 1; i <= 10; i++)
            {
                string fp = Path.Combine(pd, $"{i}.json");

                var prod = JsonConvert.DeserializeObject<List<Class1>>(File.ReadAllText(fp));
                List<Class1> filtered = prod.Where(fil).ToList();
                filtered.ForEach(p => Console.WriteLine(p.Name));
            }
        }
    }
}