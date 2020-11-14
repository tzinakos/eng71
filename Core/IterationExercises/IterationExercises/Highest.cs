using System;

namespace IterationLib
{
    public class Highest
    {
        public static int HighestWhileLoop(int[] nums)
        {
            // this method should use a while loop
            int highest = int.MinValue;
            int i = 0;
            if (nums.Length==0)
            {

            }
            else {
                while (i < nums.Length)
                {
                    if (highest < nums[i])
                    {
                        highest = nums[i];
                    }
                    i++;
                } }
            return highest;
         //   throw new NotImplementedException();
        }

        public static int HighestForLoop(int[] nums)
        {
            // this method should use a for loop
            int highest = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums.Length == 0)
                {
                    break;
                }
                if (highest < nums[i])
                {
                    highest = nums[i];
                }
            }

            return highest;


            // throw new NotImplementedException();
        }

        public static int HighestForEachLoop(int[] nums)
        {
            // this method should use a for-each loop
            int highest = int.MinValue;
            if (nums.Length == 0)
            {
                
            }
            else
            {
                foreach (int number in nums)
                {
                    if (highest < number)
                    {
                        highest = number;
                    }
                }
            }

            return highest;
           // throw new NotImplementedException();
        }

        public static int HighestDoWhileLoop(int[] nums)
        {
            // this method should use a do-while loop
            int highest = int.MinValue;
            int i = 0;
            if (nums.Length!=0) {
                do
                {
                    if (highest < nums[i])
                    {
                        highest = nums[i];
                    }
                    i++;
                } while (i < nums.Length); 
            }
            return highest;
           
            // throw new NotImplementedException();
        }
    }
}