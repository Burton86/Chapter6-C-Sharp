using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[8];
            int i;

            for (i = 0; i < 8; i++)
            {
                Write("Enter number - " + i + "<< ");
                arr[i] = Convert.ToInt32(ReadLine());
            }
            int option;
            WriteLine("Please choose option 1 for viewing the list in order from first to last," +
                " or Choose option 2 to view in order from last to first, or Choose option 3 to select a position.");
            option = Convert.ToInt32(ReadLine());
            if (option == 1)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    Write(arr[j]);
                }
            }
            else if (option == 2)
            {
                for (int b = 7; b >= 0; b--)
                {
                    WriteLine("Numbers entered are " + arr[b]);
                }
            }
            else if (option == 3)
            {
                int choice;
                WriteLine("Please pick a specific position you want to view");
                choice = Convert.ToInt32(ReadLine());
                WriteLine("The number you choose is" + arr[choice]);

            }
            ReadLine();
        }
    }
}
