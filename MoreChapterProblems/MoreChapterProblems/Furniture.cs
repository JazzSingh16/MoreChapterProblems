using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoreChapterProblems
{
    class Furniture
    {
        static void Main(string[] args)
        {
            string input;

            Console.WriteLine("Type P for Pine, O for Oak, M for Mahogany");
            input = Console.ReadLine();

            if (input == "P")
            {
                Console.WriteLine("Price is $100");
            }

            if (input != "P")
            {
                Console.WriteLine("Price is $0");
            }

            if (input == "O")
            {
                Console.WriteLine("Price is $225");
            }

            if (input != "O")
            {
                Console.WriteLine("Price is $0");
            }

            if (input == "M")
            {
                Console.WriteLine("Price is $310");
            }

            if (input != "M")
            {
                Console.WriteLine("Price is $0");
            }

          
        }
    }
}
