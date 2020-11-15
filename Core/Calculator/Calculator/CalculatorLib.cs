using System;
using System.Collections.Generic;
using System.Linq;
namespace Calculator
{
    public class CalculatorLib
    {



        public static List<double> opperants = new List<double>();
        /// <summary>
        /// stores the numbers to an array -- If the array includes two elements calles the addition function and returnes the result to its caller.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static string Add(double a)
        {
            opperants.Add(a);

            string result = "";
            if (opperants.Count == 2) // when the aray contains 2 numbers then we can purform the addition
            {
                result = (Add(opperants[0], opperants[1])).ToString();
                List<double> temp = new List<double>() { opperants[0], opperants[1] }; // creating a temp arrayList to store temporary the values of the addArray.
                opperants.Clear(); // empties the values from the list
                opperants.Add(Add(temp[0], temp[1])); // ads the summary result to the list
                temp.Clear(); // empty the temporary List

                return result;
            }
            else return "";
        }
        /// <summary>
        /// Accepts Two Integers and returns their summary.
        /// </summary>
        /// <param name="x"> integer number one</param>
        /// <param name="y"> integer number two</param>
        /// <returns></returns>
        public static double Add(double x, double y)
        {
            return x + y;
        }


        public static string Subtract(double a)
        {
            opperants.Add(a);

            string result = "";
            if (opperants.Count == 2) // when the aray contains 2 numbers then we can purform the addition
            {
                result = (Subtract((opperants[0]), opperants[1])).ToString();
                List<double> temp = new List<double>() { opperants[0], opperants[1] }; // creating a temp arrayList to store temporary the values of the addArray.
                opperants.Clear(); // empties the values from the list
                opperants.Add(Subtract(temp[0], temp[1])); // ads the summary result to the list
                temp.Clear(); // empty the temporary List

                return result;
            }
            else return "";
        }
        /// <summary>
        /// Accepts two Integers and returns their difference.
        /// </summary>
        /// <param name="x"> integer number one</param>
        /// <param name="y"> integer number two</param>
        /// <returns></returns>
        public static double Subtract(double x, double y)
        {
            return x - y;
        }

        public static string Multiply(double a)
        {
            opperants.Add(a);

            string result = "";
            if (opperants.Count == 2) // when the aray contains 2 numbers then we can purform the addition
            {
                result = (Multiply((opperants[0]), opperants[1])).ToString();
                List<double> temp = new List<double>() { opperants[0], opperants[1] }; // creating a temp arrayList to store temporary the values of the addArray.
                opperants.Clear(); // empties the values from the list
                opperants.Add(Multiply(temp[0], temp[1])); // ads the summary result to the list
                temp.Clear(); // empty the temporary List

                return result;
            }
            else return "";
        }

        /// <summary>
        /// Accepts two integers and returns their product.
        /// </summary>
        /// <param name="x"> integer number one</param>
        /// <param name="y"> integer number two</param>
        /// <returns></returns>
        public static double  Multiply(double x, double y)
        {
            return x * y;
        }

        public static string Divide(double a)
        {
            opperants.Add(a);

            string result = "";
            if (opperants.Count == 2) // when the aray contains 2 numbers then we can purform the addition
            {
                result = (Divide((opperants[0]), opperants[1])).ToString();
                List<double> temp = new List<double>() { opperants[0], opperants[1] }; // creating a temp arrayList to store temporary the values of the addArray.
                opperants.Clear(); // empties the values from the list
                opperants.Add(Divide(temp[0], temp[1])); // ads the summary result to the list
                temp.Clear(); // empty the temporary List

                return result;
            }
            else return "";
        }

        /// <summary>
        /// Accepts two integer and returns their division result.
        /// </summary>
        /// <param name="x"> integer number one</param>
        /// <param name="y">integer number two</param>
        /// <returns></returns>
        /// 
        public static double Divide(double x, double y)
        {
            if (y == 0)
            {
                throw new System.ArgumentException("You can not divide by 0", "y");
            }
            else
                return x / y;
        }
        /// <summary>
        /// Accepts two integer and returns the remaider of their division.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static double Module(double x, double y)
        {
            return x % y;
        }
    }
}


