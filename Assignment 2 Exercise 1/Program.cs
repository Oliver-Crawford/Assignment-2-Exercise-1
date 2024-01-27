using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write an application to display an input integer in reverse order and the sum of all digits.
             * For example, ifuser inputs 12345, it will display 54321, and sum is 15.
             */
            Console.WriteLine("Please input a whole number.");
            bool isInt = false;
            int inputInt = 0;
            string input = "";
            int intSum = 0;
            while (!isInt)
            {
                input = Console.ReadLine();
                isInt = int.TryParse(input, out inputInt);
                if(!isInt)
                {
                    Console.WriteLine("Invalid input, try again.");
                }
            }
            for(int i = input.Length-1; i >= 0; i--)
            {
                Console.Write(input[i]);
                intSum += (int)Char.GetNumericValue(input[i]);
                
            }
            Console.WriteLine();
            Console.WriteLine($"Sum is {intSum}");
            Console.ReadLine();
        }
    }
}
