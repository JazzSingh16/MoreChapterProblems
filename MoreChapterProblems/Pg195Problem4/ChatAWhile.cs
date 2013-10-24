using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pg195Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] zip = new int[10];
          
            zip[0] = 262;
            zip[1] = 414;
            zip[2] = 608;
            zip[3] = 715;
            zip[4] = 815;
            zip[5] = 920;

            Console.WriteLine("Enter your area code");
            string input = Console.ReadLine();
            int myzip = Convert.ToInt32(input);

            {

                if (myzip == zip[0])
                {
                    Console.WriteLine("Per-Minute Rate($) is 0.07, which is multiplied by {0} minutes of the call");
                }
                if (myzip == zip[1])
                {
                    Console.WriteLine("Per-Minute Rate($) is 0.10, which is multiplied by {0} minutes of the call");
                }
                if (myzip == zip[2])
                {
                    Console.WriteLine("Per-Minute Rate($) is 0.05, which is multiplied by {0} minutes of the call");
                }
                if (myzip == zip[3])
                {
                    Console.WriteLine("Per-Minute Rate($) is 0.16, which is multiplied by {0} minutes of the call");
                }
                if (myzip == zip[4])
                {
                    Console.WriteLine("Per-Minute Rate($) is 0.24, which is multiplied by {0} minutes of the call");
                }
                if (myzip == zip[5])
                {
                    Console.WriteLine("Per-Minute Rate($) is 0.14, which is multiplied by {0} minutes of the call");
                }


              
            }
        }
    }
}
