using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CheckZipsMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] zips = { 11111, 22222, 33333, 44444, 55555, 66666, 77777, 88888, 99999, 10101 };
            int userZip = 0;

            WriteLine("Enter a 5 digit zip code to see if you area code is eligible for us to deliver to you. >>> ");
            userZip = Convert.ToInt32(ReadLine());

            for (int i = 0; i < 1; i++)
            {
                if (zips[i] == userZip)
                {
                    WriteLine("We can deliver to your area!");
                }
                else
                {
                    WriteLine("We do not deliver to your area");
                }
            }
           
        }
    }
}
