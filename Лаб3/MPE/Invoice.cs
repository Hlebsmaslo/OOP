using System;
using System.Collections.Generic;

namespace MPE
{
    internal class Invoice
    {
        private readonly int acc;
        private readonly string cus;
        private readonly string pro;
        private string art;
        private int qua;
        public int Quantity
        {
            get { return qua; }
            set { qua = value; }
        }
        public string Article
        {
            get { return art; }
            set { art = value; }
        }
        private double su;
        public double Sum
        {
            get { return su; }
            set { su = value; }
        }
        public Invoice(int account,string customer,string provider)
        {
            this.acc = account;
            this.cus = customer;
            this.pro = provider;
        }
        public double tax()
        {
            double tax = 0;
            double sum = 0;
            Sum = sum;
            Random random = new Random();
            int price = random.Next(1, 1000);
            qua = acc / price;
            Article.ToLower();
            switch (Article)
            {
                case "with":
                    {
                        tax = 0.20;
                        sum = (price * qua) * tax;
                        break;
                    }
                case "without":
                    {
                        sum = price * qua;
                        break;
                    }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(10000, "1", "2");
            Console.WriteLine("Якщо хочете з пдв, введiть - with");
            Console.WriteLine("Якщо хочете без пдв, введiть - without");
            string article = Console.ReadLine();
            invoice.Article = article;
            Console.WriteLine(invoice.tax());
        }
    }
}
