using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab_09_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
        //    var myAl = new ArrayList();
        //    myAl.Add("Jino");
        //    myAl.Add('d');
        //    myAl.Add(2);

        //foreach(var item in myAl)
        //    {
        //        Console.WriteLine(item);
        //    }
            

            List<int> exList = new List<int>() { 1, 2, 3, 4, 5 };

            //Console.WriteLine("FirstPrint");
            //exList.ForEach(x => Console.WriteLine( x));
            //Console.WriteLine("");
            //exList.Add(6);
            //exList.Add(7);
            //exList.Add(8);
            //exList[2] = 4;
            //exList.Reverse();
            //exList.Remove(3);
            //Console.WriteLine("Second Print");
            //exList.ForEach(x => Console.WriteLine( x ));
            //Console.WriteLine("");
            //exList.Sort();
            //Console.WriteLine("Last Print");
            //exList.ForEach(x => Console.WriteLine( x));

            // Queue: FIFO
            //Queue<string> myQueue = new Queue<string>();
            //myQueue.Enqueue("Jino \n");
            //myQueue.Enqueue("Biba \n");

            //Console.WriteLine(myQueue.Peek());
            //Console.WriteLine(myQueue.Dequeue());

            //foreach (var item in myQueue)
            //{
            //    Console.WriteLine($"{item} \n ");
            //}

            //Stack: LIFO

            //var myStack = new Stack<string>();

            //myStack.Push("Jino");
            //myStack.Push("Biba");

            //Console.WriteLine(myStack.Pop());
            //foreach (var item in myStack)
            //{
            //    Console.WriteLine($"{item} \n ");
            //}

            //HashSet<T>
            //var trainer = new HashSet<string> {"trainer1","trainer1", "trainer2" }

            //Dictionary
            var myDictionary = new Dictionary<int, String>();
            myDictionary.Add(1, "Paula Kedra");
            myDictionary.Add(2, "David Harley");
            myDictionary.Add(3, "Lee Boot");
            myDictionary.Add(4, "Nish Mandal");
            myDictionary.TryAdd(4, "Jino Biba");


            var dictionary2020 = new Dictionary<char, string> { 
                {'c', "cat" }, {'d', "dog" } 
            };

            var p = dictionary2020['p'];
            foreach (var item in dictionary2020.Keys)
            {
                Console.WriteLine($"Index/key is {item} and value is {dictionary2020[item]}");
            }

            string input = "There is always only one truth!";
            input.Trim().ToLower();

            var countDict = new Dictionary<char, int>();

            foreach (char item in input)
            {
                if (countDict.ContainsKey(item))
                {
                    countDict[item]++;
                }
                else
                {
                    countDict.Add(item, 1);
                }
            }


        }


    }
}
