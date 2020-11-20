using System;

namespace Lab_11_Exeptions
{
    public class Program
    {
        static void Main(string[] args)
        {
                    string[] kati = new string[] { "George", "Papas", "Lakis", "Takis" };

        }

        public static void ChangeBeatle(int pos, string name)
        {
            string[] kati = new string[] { "George", "Papas", "Lakis", "Takis" };

            if (pos < 0 || pos > kati.Length)
            {
                try
                {
                    kati[pos] = name;
                }
                catch
                {           
                }
            }
        }
    }
}
