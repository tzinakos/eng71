using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Lab_06_ArraysAndStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //array of char
            char[] charArray = { 'J', 'i', 'n', 'o' };
            var charArray2 = new char[] { 'J', 'i', 'n', 'o' };
            char[] charArray3 = new char[4];

            //two dimentional arrays
            int[,] grid = new int[2, 4]; //Tow Rows, Four Columns
            int[,] grid2 = new int[2, 4] { { 3, 4, 2, 1 }, { 5, 7, 5, 4 } };

            //4rth dimentional array
            int[,,,] grid4 = new int[2, 3, 1, 2];

            //jugged arrays
            string[][] animalGrid = new string[2][];
            animalGrid[0] = new string[4];
            animalGrid[1] = new string[3];

            string[][] enj71 = new string[][]
            {
                 new string[]{"Kishan","Breesha","Beanka","Leonard"},
                 new string[] { "Dom", "Greg", "Mansib", "Ayo" }
            };

            char[][] city = new char[5][];
            city[0] = new char[5];
            city[1] = new char[10];
            city[2] = new char[20];
            city[3] = new char[40];
            city[4] = new char[80];

            city[0][0] = 'B';
            city[0][1] = 'a';
            city[0][2] = 't';
            city[0][3] = 'h';

            string cityName = ($"{city[0][0]}{city[0][1]}{city[0][2]}{city[0][3]} ");
            Console.WriteLine(cityName);

            //create a list
            List<string> arrayList = new List<string>();
            arrayList.Add("itemNumerOne");
            arrayList.Add("itemNumberTwo");

            var eng71 = new List<string> {"Lauren","Gino"};
            //strings
            string name = "Gregory";

            int length = name.Length;
            name = name.ToUpper();
            Console.WriteLine(name+" "+length);

            var spaceName = "   Bresha   ";
            var trimName = spaceName.Trim();
            Console.WriteLine(trimName);

            //Concat
            string fName = "Jino";
            String lName = "Biba";
            Console.WriteLine("What is you age?");
            int age = Convert.ToInt32(Console.ReadLine());
            string fullName = $"His name is {fName} {lName} and his age is: {age}";
            Console.WriteLine(fullName);


            bool success = int.TryParse(Console.ReadLine(), out int numAge);
            if (success)
            {
                Console.WriteLine(numAge);
            }
            else
            {
                Console.WriteLine("Fail");
            }


            StringBuilder sb = new StringBuilder();

            sb.Append("Hello ");
            sb.Append("World!");
            Console.WriteLine(sb.ToString());
            

        }

        
       
    }
}
