using System;
using System.Diagnostics;

namespace Lab_10_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime & TimeSpan
            //var tps = TimeSpan.TicksPerSecond;
            //var nowInTicks = DateTime.Now.Ticks;

            //var d = new DateTime();
            //var di = DateTime.Today;
            //var d2 = DateTime.Now;
            //var d3 = new DateTime(1995,11,24,6,30,0);

            //var dateDiff = d2 - d3;
            //var JinoAgeYears = (int)(dateDiff.Days /365.25) ;

            //var output = JinoAgeYears.ToString("dd-MM-yyyy");
            //Console.WriteLine(output);

            //Timespan - stopwatch

            //var timeSpan = new TimeSpan(1,0,0);
            //var dt = new DateTime(1995, 11, 24, 6, 30, 0);
            //var date = dt + timeSpan;
            //var date2 = DateTime.Now + timeSpan;

            //StopWatch
            //var s = new Stopwatch();
            //s.Start();
            //int total = 0;
            //for (int i=0; i<1000; i++)
            //{
            //    total += 1;
            //}

            //s.Stop();
            //Console.WriteLine(s.Elapsed);
            //Console.WriteLine(s.ElapsedMilliseconds);
            //Console.WriteLine(s.ElapsedTicks);
            //Console.ReadLine();

            //Enumerators

            //Suit theSuit = Suit.Hearts;
            //var c = (int)'c';
            //var theSuitInt = (int)theSuit;

            //char t = (char)1;
            //Suit theSuit2 = (Suit)3;
            //Suits(theSuit2);

            //int dog;
            //float cat;
            //char x;
            //DateTime aDate;
            //string aString;
            //bool thing;
            //int[] arr;

            //  int sparta; ///Default value = 0
            //  int? global; ///Default value = null
            ////  Nullable<int> global;

            //  bool? hasPassed = null;

            //  if (hasPassed.HasValue)
            //  {
            //      Console.WriteLine($"hasPassed has a value of null");
            //  }

            //  int totalCost = 0;
            //  int price = 1;

            //  int? items = 3;

            //  if (items.HasValue)
            //  {
            //      totalCost = items.Value * price;
            //  }
            //  Console.WriteLine(items.HasValue);
            //  Console.WriteLine(totalCost);

            //int? nullableScore = null;
            //int score = nullableScore ?? -9999;
            //int score1 = nullableScore.GetValueOrDefault(-1);
            //int score2 = nullableScore.GetValueOrDefault();

            var rng = new Random();
            var rngSeeded = new Random(50);
            var between1And10 = rngSeeded.Next(1, 11);

            Console.WriteLine(between1And10);


        }

        //public static void Suits(Suit suit)
        //{
        //    switch (suit)
        //    {
        //        case Suit.Hearts:
        //            Console.WriteLine("You have stolen it");
        //            break;
        //        case Suit.Clubs:
        //            Console.WriteLine("Club foot");
        //            break;
        //        case Suit.Diamonds:
        //            Console.WriteLine("Best Friend");
        //            break;
        //        case Suit.Spades:
        //            Console.WriteLine("Shovel?");
        //            Console.WriteLine();
        //            break;         
        //    }
        //}
        //public enum Suit
        //{
        //    Hearts, Clubs, Diamonds, Spades
        //}
    }
}
