using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Delivery
    {
        static void Main(string[] args)
        {
            bool found = false;
            int[] zip = new int[10];
            zip[0] = 18042;
            zip[1] = 18043;
            zip[2] = 18044;
            zip[3] = 18045;
            zip[4] = 18046;
            zip[5] = 18047;
            zip[6] = 18048;
            zip[7] = 18049;
            zip[8] = 18031;
            zip[9] = 18032;



            Console.WriteLine("What is your zip code?");
            string input = Console.ReadLine();
            int myzip = Convert.ToInt32(input);

            for (int i = 0; i < zip.Length; i++)
            {
                
                if(myzip == zip[i]) 
                {
                    Console.WriteLine("Yes we deliever there");
                }
                if (!found)
                {
                    Console.WriteLine("No we do not deliever there");
                }
            }

        }
    }
}
