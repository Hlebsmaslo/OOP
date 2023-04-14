using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var fpath = @"D:\контент для дрочілок";
        var rp = GenerateReport(fpath, Tokenize, CalculateWordFrequencies, PrintReport);
        Console.WriteLine(rp);
    }
    static string GenerateReport(string fpath, Func<string, IEnumerable<string>> tk, Func<IEnumerable<string>, IDictionary<string, int>> wcalc, Action<IDictionary<string, int>> reportPrinter)
    {
        var allw = new List<string>();
        var fl = Directory.EnumerateFiles(fpath, "*.txt");
        foreach (var f in fl)
        {
            var text = File.ReadAllText(f);
            var w = tk(text);
            allw.AddRange(w);
        }
        var wordFrequencies = wcalc(allw);
        reportPrinter(wordFrequencies);
        return $"Обробленi {fl.Count()} файли в папцi {fpath}";
    }
    static IEnumerable<string> Tokenize(string text)
    {
        var sp = new[] { ' ', '\t', '\n', '\r', ',', '.', '!', '?' };
        return text.Split(sp, StringSplitOptions.RemoveEmptyEntries).Select(word => word.ToLowerInvariant());
    }
    static IDictionary<string, int> CalculateWordFrequencies(IEnumerable<string> words)
    {
        var m = new Dictionary<string, int>();
        foreach (var word in words)
        {
            if (!m.ContainsKey(word))
            {
                m[word] = 0;
            }
            m[word]++;
        }
        return m;
    }
    static void PrintReport(IDictionary<string, int> wordFrequencies)
    {
        Console.WriteLine("Частота слiв:");
        foreach (var pa in wordFrequencies.OrderByDescending(pa => pa.Value))
        {
            Console.WriteLine($"{pa.Key} - {pa.Value}");
        }
    }
}
