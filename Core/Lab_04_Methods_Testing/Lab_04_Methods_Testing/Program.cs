using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04_Methods_Testing
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            DoThis();
            int absolute = DoThat(-3);
            Console.WriteLine(absolute);
            DoThatAgain(2, z: 3);
            var result = Out(11, "hello", out bool isLarge);
            Console.WriteLine($"{ result} \n{isLarge}");
            Console.WriteLine("Press Enter or Return to close this window");
            Console.ReadLine();
            
            
        }

            public static void DoThis()
            {
                Console.WriteLine("I am doing something");

            }

        public static int DoThat(int x)
        {
            Console.WriteLine($"I am returning The absolute value of the {x}");
            return Math.Abs(x);
           
        }
        /// <summary>
        /// This Method takes 3 parameters and returns the sum of the first and the third one.
        /// The first parameter is an int, the secont is a string with a default value of "This is a default value " 
        /// and the third parameter is an int and has a default value of 1
        /// </summary>
        /// <param name="x"> int </param>
        /// <param name="y"> string Default: "This is a default value"  </param>
        /// <param name="z">int Default: 1</param>
        /// <returns></returns>
        public static int DoThatAgain(int x, string y = "This is a default value", int z =1)
        {
            Console.WriteLine($"{x} {y} {z}");
            return x+z;
            
        }

        public static int Out(int x, string s, out bool z) {
            z = (x > 10);
            return x * x;
                

        }

        public static int Add(int x)
        {
            
            return ++x;
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int TricpleCalc(int a, int b, int c, out int sum)
        {
            sum = a + b + c;
            return a * b * c;
        }

        public static (int sum, int product) TricpleCalc(int a, int b, int c)
        {
            int sum = a + b + c;
            int product = a * b * c;
            return (sum, product);
        }


      //  public static  (int xsquared, bool) TupleExample(int x, string y)
      // {
      //    Console.WriteLine(y);
      //   var z = (x > 10);
      //  return (x * x, z);
      // }




    }

}
