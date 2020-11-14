using System;

namespace Lab_07_Iterations
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] myArray = new int[] 
            {
            10,20,30
            };
            Console.WriteLine("Hello World!");
            //// Iterations

            //// for loops

            //// for (int i = 0; i <= 100; i++)
            //// {               
            ////  Console.WriteLine(100-i);
            //// }
            // for (int i = 100; i >= 0; i--)
            // {
            //     Console.WriteLine(i);
            // }

            // // foreach loop
            // foreach (var item in myArray)
            // {
            //     Console.WriteLine(item);
            // }

            // // wile loops
            // int counter = 0;
            // while (counter < 10)
            // {
            //     Console.WriteLine(counter*10);
            //     counter++;
            // }

            // // do... while loop

            // int docounter = 1;
            // do
            // {
            //     Console.WriteLine(docounter * 10);
            //     docounter++;
            // } while (docounter <= 10);

            // int sum = 0;
            // for (int i = 0; i <= 100; i++)
            // {
            //     sum += i;
            // }
            // Console.WriteLine(sum);

            // string result = "";
            // foreach (char x in "NISH IS KING")
            // {
            //     result += x.ToString().ToLower();

            // }
            // Console.WriteLine(result);

            // break
            //    for (int i =0; i<10; i++)
            //    {
            //        Console.WriteLine("i");
            //        if (i == 5)
            //        {
            //            break;
            //        }
            //    }

            ////continue
            //int counter = 0;

            //while (counter < 10) 
            //{
            //    counter++;
            //    Console.WriteLine(counter);

            //    if (counter < 4) continue;
            //    Console.WriteLine(counter *4);
            //}

            for (int i = 0; i <= 20; i++)
            {
                if ( i%15 == 0 ) {

                    break;

                } else Console.WriteLine(i);


            }
        }
    }
}
