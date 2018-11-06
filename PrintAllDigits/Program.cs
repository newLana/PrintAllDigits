using System;
using System.Linq;

namespace PrintAllDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintDigits(12245891);
            Console.ReadKey();
        }

        static void PrintDigits(int num)
        {            
            string s = num.ToString();
            if (s.Length > 1)
            {               
                PrintDigits(Int32.Parse(s.Remove(s.Length - 1)));
            }
            Console.Write(Int32.Parse(s.Last().ToString()));
        }
    }
}
