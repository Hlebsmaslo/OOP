using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2User
{
    internal class Program
    {
        public class User
        {
            public string login {get;set;}
            public string name {get;set;}
            public string name2 {get;set;}
            public string age {get;set;}
            public string date {get;set;}
            public void use()
            {
                Console.WriteLine("Ваш логiн -");
                login = Console.ReadLine();
                Console.WriteLine("Ваше iм'я");
                name = Console.ReadLine();
                Console.WriteLine("Ваше прiзвище");
                name2 = Console.ReadLine();
                Console.Write("Ваш вiк");
                age = Console.ReadLine();
                date = DateTime.Now.ToString();
                Console.WriteLine($"Ваш логiн - {login}. звати - {name} {name2}, вiк - {age}. анкета створена - {date} ");
            }
            static void Main(string[] args)
            {
                User user = new User();
                user.use();
            }
        }
    }
}
