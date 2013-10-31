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

            for (int i = 0; i < zip.Length; i++)
            {

                if (myzip == zip[i])
                {
                    Console.WriteLine("Per-Minute Rate($) is {0}, which is multiplied by {1} minutes of the call", zip[i]);
                }
            }
        }
    }
}
