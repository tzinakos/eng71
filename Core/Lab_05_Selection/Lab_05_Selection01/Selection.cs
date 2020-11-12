using System;
using System.Net.Mail;
using System.Windows.Markup;

namespace Lab_05_Selection01
{
    public class Selection
    {
        static void Main(string[] args)
        {
           
            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuseday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }
            Grade(79);
            Priority(3);
            
           
        }      

        public static string Grade(int mark)
        {
            var grade = "";
            if (mark >= 40)
            {
                grade = "Pass";
                if (mark >= 75)
                {
                    grade += " With Distinction";
                }
                else if (mark >= 60)
                {
                    grade += " With Merit";
                }
            }
            else grade = "Fail";
             return grade;


        }

        public static string Priority(int level)
        {
            string priority = "Code";
            switch (level)
            {
                case 0:
                    priority += " Green";
                    break;
                case 1:
                    priority += " Amber";
                    break;
                case 2:
                    priority += " Amber";
                    break;
                case 3:
                    priority += " Red";
                    break;
                default:
                    priority = "Error";
                    break;
            }
            return priority;
        }
    }
}
