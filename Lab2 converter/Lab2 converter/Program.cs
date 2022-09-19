using System;
using System.Globalization;

namespace Lab2_converter
{
    class Converter
    {
        private double uah {get;set;}
        private readonly double usd;
        private readonly double eur;
        //без рублів..//
        public Converter(double USD, double EUR)
        {
            this.usd = USD;
            this.eur = EUR;
        }
        public double converte()
        {
            int num1;
            int num2;
            num1 = Convert.ToInt32(Console.ReadLine());
            switch (num1)
            {
                case 1:
                    Console.WriteLine("USD to UAH");
                    Console.WriteLine("Введiть USD:");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    uah = num2 * usd;
                    Console.WriteLine($"Ви отримаєте {uah} гривень.");
                    System.Threading.Thread.Sleep(4000);
                    break;

                case 2:
                    Console.WriteLine("EUR to UAH");
                    Console.WriteLine("Введiть EUR:");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    uah = num2 * eur;
                    Console.WriteLine($"Ви отримаєте {uah} гривень.");
                    System.Threading.Thread.Sleep(4000);
                    break;

                case 3:
                    Console.WriteLine("UAH to USD");
                    Console.WriteLine("Введiть гривнi:");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    double UsD = num2 / 26.3;
                    Console.WriteLine($"Ви отримаєте {UsD} долларів.");
                    System.Threading.Thread.Sleep(4000);
                    break;

                case 4:
                    Console.WriteLine("UAH to EUR");
                    Console.WriteLine("Введiть гривнi:");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    double EuR = num2 / 30.4;
                    Console.WriteLine($"Ви отримаєте {EuR} євро.");
                    System.Threading.Thread.Sleep(4000);
                    break;

                default:
                    Console.WriteLine("Ви ввели неправильне число");
                    System.Threading.Thread.Sleep(4000);
                    break;
            }
            return uah;
       }
        static void Main(string[] args)
        {
            Console.WriteLine("1 - USD to UAH, 2 - EUR to UAH, 3 - UAH to USD, 4 - UAH to EUR.");
            Converter converter = new Converter(26.3, 30.4);
            converter.converte();
        }
    }
}

