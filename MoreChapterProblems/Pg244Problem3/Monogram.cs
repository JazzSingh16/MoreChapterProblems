using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pg244Problem3
{
    class Monogram
    {
        public static void Main()
        {
            
            DisplayMonogram("E", "J", "L");
            DisplayMonogram("W", "K", "H");

            
            Console.ReadKey();


        }
        public static void DisplayMonogram(string first, string middle, string last)
        {
            Console.WriteLine("** {0}. {1}. {2}. **", first, middle, last);
        }
    }
}