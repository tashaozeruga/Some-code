using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            Man m1 = new Man();
            Man m2 = new Man();

            m1.name = "Vasya";
            m2.name = "Kolya";

            m1.say_name();
            m2.say_name();

            string name = "Masha";
            Console.WriteLine("My name is " + name);

        }
    }
}
