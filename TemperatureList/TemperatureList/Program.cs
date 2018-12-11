using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TemperatureList
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] temp = new int[7];
            int i;
            int TempAverage;
            int total = 0;

            for (i = 0; i <temp.Length; i++)
            {
                WriteLine("Please enter the High tempertaures for seven days");
                temp[i] = Convert.ToInt32(ReadLine());
                total = temp[i] + total;
            }
            TempAverage = total / temp.Length;
            WriteLine("Temperature average = " + TempAverage);
            for (int j = 0; j < temp.Length; j++) {
                WriteLine("The difference for temp " + temp[j] + " and the average is " + (temp[j] - TempAverage));
            }
            
        }
    }
}
