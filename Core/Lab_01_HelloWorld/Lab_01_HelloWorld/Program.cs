using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            foreach (var item in args)
            {
                Console.WriteLine($"{item} is in eng71");

            }
            Console.ReadLine();
        }
    }
}
