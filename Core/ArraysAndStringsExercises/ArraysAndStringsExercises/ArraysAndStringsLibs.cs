
using System;
using System.Text;

namespace ArraysAndStringsLib
{
    public class Exercises
    {
        // returns a formatted address string given its components
        public static string Address(int number, string street, string city, string postcode)
        {
            return $"{number} {street}, {city} {postcode}.";
          //  throw new NotImplementedException();
        }
        // returns a string representing a test score, written as percentage to 1 decimal place
        public static string Scorer(int score, int outOf)
        {
            if (outOf==0)
            {
                throw new DivideByZeroException("outOf can not be Zero (0)");
            }
            else {
                double percentage = (double)score * 100 / (double)outOf;
                return $"You got {score} out of {outOf}: {Math.Round(percentage, 1)}%";
            }
            
        }

        // returns the double represented by the string, or -999 if conversion is not possible
        public static double ParseNum(string numString)
        {
            bool success = double.TryParse(numString, out double result);
            return success? result : -999;
          //return double.TryParse(numString, out double result)? result: -999;
          //  throw new NotImplementedException();
        }
        public static string ManipulateString(string input, int num)
        {
            string result =input.Trim().ToUpper();

            for(int i = 0; i < num; i++)
            {
                result+= i.ToString();
            }
            return result;
            //throw new NotImplementedException();
        }
    }
}