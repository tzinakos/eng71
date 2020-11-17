
using System.Collections.Generic;

namespace CollectionsExercises
{
    public class CollectionsExercise
    {
        /* removes and returns the next num entries in the queue, as a comma separated string */
        public static string NextInQueue(int num, Queue<string> queue)
        {
            string result = "";

            if (num <= queue.Count)
            {
                for (int i = 0; i < num; i++)
                {
                    if (i == num - 1)
                    {

                        result += $"{queue.Dequeue()}";
                    }
                    else
                    {
                        result += $"{queue.Dequeue()}, ";
                    }
                }
            }
            else
                
                for (int i = queue.Count; i!=0 ; i--)
                {
                    if (i == 1)
                    {
                        
                        result += $"{queue.Dequeue()}";
                    }
                    else
                    {
                        result += $"{queue.Dequeue()}, ";
                    }
                }

            return result;
        }

        /* uses a Stack to create and return array of ints in reverse order to the one supplied */
        public static int[] Reverse(int[] original)
        {
            Stack<int> reverse = new Stack<int>();
           // int[] originalReversed = new int[original.Length];

            foreach (int number in original)
            {
                reverse.Push(number);
            }            
            //int i = 0;
            //foreach (int reversedNumber in reverse)
            //{
            //    originalReversed[i] = reversedNumber;
            //    i++;
            //}

            return reverse.ToArray(); 
        }
        // using a Dictionary, counts and returns (as a string) the occurence of the digits 0-9 in the given string
        public static string CountDigits(string input)
        {
            Dictionary<char, int> occurance = new Dictionary<char, int>();
            occurance.Add('0' ,0); occurance.Add('1', 0); occurance.Add('2', 0);
            occurance.Add('3', 0); occurance.Add('4', 0); occurance.Add('5', 0);
            occurance.Add('6', 0); occurance.Add('7', 0); occurance.Add('8', 0);
            occurance.Add('9', 0);
           
            string output="";

            foreach (char num in input)
            {
                if (occurance.ContainsKey(num))
                {
                    occurance[num] += 1;
                }
            }

            List<char> printed = new List<char>();

            foreach (char num in input)
            {
                if (occurance.ContainsKey(num)){

                    if (!printed.Contains(num)){
                        output += $"[{num}, {occurance[num]}]";
                        printed.Add(num); 
                    }
                } 
            }
            return output;
        }
    }
}