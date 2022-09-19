using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Address
    {
        public int Index {get;set;}
        public string Country {get;set;}
        public string City {get;set;}
        public string Street {get;set;}
        public string House {get;set;}
        public string Apartment {get;set;}
        public void Adress()
        {
            Console.WriteLine($"Iндекс: {Index} Країна: {Country} Мiсто: {City} Вулиця: {Street} БУдинок: {House} Номер квартири: {Apartment}");
        }
        static void Main()
        {
            Address addres = new Address();
            addres.Index = 04109;
            addres.Country = "Україна";
            addres.City = "Київ";
            addres.Street = "проспект Перемоги";
            addres.House = "108";
            addres.Apartment = "6";
            addres.Adress();
        }
    }

}