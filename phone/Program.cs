using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace phone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            phone phone1 = new phone("555-555", "Samsung", 0.5);
            phone phone2 = new phone("444-444", "Iphone");
            phone phone3 = new phone();

            Console.WriteLine("Первый телефон:");
            Console.WriteLine("Номер: " + phone1.getNumber());
            Console.WriteLine("Модель: " + phone1.model);
            Console.WriteLine("Вес: " + phone1.weight);

            Console.WriteLine("Второй телефон:");
            Console.WriteLine("Номер: " + phone2.getNumber());
            Console.WriteLine("Модель: " + phone2.model);
            Console.WriteLine("Вес: " + phone2.weight);

            Console.WriteLine("Третий телефон:");
            Console.WriteLine("Номер: " + phone3.getNumber());
            Console.WriteLine("Модель: " + phone3.model);
            Console.WriteLine("Вес: " + phone3.weight);

            phone1.receiveCall("Никита");
            phone2.receiveCall("Сеня", "111-222-3333");
            phone3.receiveCall("Артем");

            phone1.sendMessage("111-222-3333", "444-555-6666");
            Console.ReadKey();
        }
    }
}
