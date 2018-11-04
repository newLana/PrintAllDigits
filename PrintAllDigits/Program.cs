using System;
using System.Linq;

namespace PrintAllDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintDigits(122);
            Console.ReadKey();
        }

        static void PrintDigits(int num)
        {            
            string s = num.ToString();
            int _num = Int32.Parse(s.Last().ToString());
            if (s.Length > 1)
            {               
                PrintDigits(Int32.Parse(s.Remove(s.Length - 1)));
            }
            Console.Write(_num);
        }
    }
}
