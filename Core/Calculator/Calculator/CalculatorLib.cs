using System;

namespace Calculator
{
    public class CalculatorLib
    {
        /// <summary>
        /// Accepts Two Integers and returns their summary.
        /// </summary>
        /// <param name="x"> integer number one</param>
        /// <param name="y"> integer number two</param>
        /// <returns></returns>
        public static int Add(int x, int y)
        {
            return x + y;
        }
        /// <summary>
        /// Accepts two Integers and returns their difference.
        /// </summary>
        /// <param name="x"> integer number one</param>
        /// <param name="y"> integer number two</param>
        /// <returns></returns>
        public static int Subtract(int x, int y)
        {
            return x - y;
        }
        /// <summary>
        /// Accepts two integers and returns their product.
        /// </summary>
        /// <param name="x"> integer number one</param>
        /// <param name="y"> integer number two</param>
        /// <returns></returns>
        public static int Multiply(int x, int y)
        {
            return x * y;
        }
        /// <summary>
        /// Accepts two integer and returns their division result.
        /// </summary>
        /// <param name="x"> integer number one</param>
        /// <param name="y">integer number two</param>
        /// <returns></returns>
        public static int Divide(int x, int y)
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
        public static int Module(int x, int y)
        {
            return x % y;
        }
    }
}


