using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pg244Problem3
{
    class Monogram
    {
        static void Main(string[] args)
        {
            string myfirst;
            string mymiddle;
            string mylast;

            string friendfirst;
            string friendmiddle;
            string friendlast;
            

            DisplayMonogram(myfirst, mymiddle, mylast);
            
        }
        public static void DisplayMonogram(string first, string middle, string last)
        {
            Console.WriteLine("** {0}. {1}. {2}. **", first, middle, last);


        }
        }
    }
}
