using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phone
{
    internal class phone
    {
        public string number;
        public string model;
        public double weight;
        public phone(string number, string model, double weight)
        {
            this.number = number;
            this.model = model;
            this.weight = weight;
        }
        public phone(string number, string model)
        {
            this.number = number;
            this.model = model;
            weight = 0;
        }
        public phone()
        {
            number = "";
            model = "";
            weight = 0;
        }
        public void receiveCall(string name)
        {
            Console.WriteLine("Звонит " + name);
        }
        public void receiveCall(string name, string callNumber)
        {
            Console.WriteLine("Звонит " + name + " с номера: " + callNumber);
        }
        public string getNumber()
        {
            return number;
        }
        public void sendMessage(params string[] numbers)
        {
            Console.WriteLine("Отправляем сообщение на номера:");

            foreach (string number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
    

