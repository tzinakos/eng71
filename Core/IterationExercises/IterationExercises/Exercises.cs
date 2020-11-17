using System;

namespace IterationLib
{

    public class Program
    {
       
        public static void Main(string[] args)
        {
            //ignore
        }
    }
    public class Exercises
    {
        // returns the lowest number in the array nums
        public static int Lowest(int[] nums)
        {
            int result = int.MaxValue;
            if (nums.Length==0)
            {
                result = int.MaxValue;
            }
            else
            {

                for (int i = 0; i < nums.Length; i++)
                {
                    if (result > nums[i])
                    {
                        result = nums[i];
                    }
                }
            }
            return result;
        }

        // returns the sum of all numbers between 1 and n inclusive that are divisible by either 2 or 5
        public static int SumEvenFive(int max)
        {
            int sum = 0;
            for (int i = 1; i <= max; i++)
            {
                if (i % 2 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }

        // Returns the a string containing the count of As, Bs, Cs and Ds in the parameter string
        // all other letters are ignored
       
        public static string CountLetters(string input)
        {
            int aCounter = 0, bCounter = 0, cCounter = 0, dCounter = 0;
            foreach (char x  in input)
            {
                switch (x)
                {
                    case 'A': aCounter++;
                        break;
                    case 'B':
                        bCounter++;
                        break;
                    case 'C':
                        cCounter++;
                        break;
                    case 'D':
                        dCounter++;
                        break;
                    default:
                        continue;
                }
            }

            return $"A:{aCounter} B:{bCounter} C:{cCounter} D:{dCounter}";

        }
    }
}