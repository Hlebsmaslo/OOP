using System;
using System.Collections.Generic;
using System.IO;
using JSON;
using Newtonsoft.Json;

class Program
{
    static void Main()
    {
        string file = "ogo.json";
        var filtcrt = new List<Predicate<Products>>();
        filtcrt.Add(p => p.Price < 50);  
        filtcrt.Add(p => p.Quantity > 0); 
        FilterAndDisplayProducts(file, filtcrt);
    }

    static void FilterAndDisplayProducts(string File, List<Predicate<Products>> filters)
    {
        string jsonContent = System.IO.File.ReadAllText(File);
        var products = JsonConvert.DeserializeObject<List<Products>>(jsonContent);
        var filtered = new List<Products>();
        foreach (var product in products)
        {
            bool isf = true;
            foreach (var filter in filters)
            {
                if (!filter(product))
                {
                    isf = false;
                    break;
                }
            }
            if (isf)
            {
                filtered.Add(product);
            }
        }
        foreach (var product in filtered)
        {
            Console.WriteLine($"Назва: {product.Name}, Ціна: {product.Price}, Кількість: {product.Quantity}");
        }
    }
}


