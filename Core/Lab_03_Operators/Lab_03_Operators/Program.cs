using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = 1, l = 2;
            Console.WriteLine(t);
            Console.WriteLine(l);
            t = +l;
            Console.WriteLine(t);
            Console.WriteLine(l);
            Console.WriteLine(t);
            Console.WriteLine(l);
            int x = 2, y = 0;

            y = x++;
            int a = 2, b = 0;

            b = ++a;
            Console.WriteLine($"{a}{ b}{x}{y}");
            Console.ReadLine();

            bool isWearingAParachute = false;
            bool jumpOutOfPlane = true;

            if (isWearingAParachute && jumpOutOfPlane) {
                Console.WriteLine("Jump");
            }
            else
            {
                Console.WriteLine("Dont Jump");
            }
            Console.WriteLine(5 & 1);
            Console.WriteLine(5 |1);
            Console.WriteLine(5 ^ 1);
            


            Console.ReadLine();

            Console.WriteLine(9 << 3);
            Console.WriteLine(Convert.ToString(9,3));
            Console.WriteLine(Convert.ToString(5, 2));
            Console.ReadLine();
        }

        
    }
}
