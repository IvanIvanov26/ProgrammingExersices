using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersice4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string decimalInput = Console.ReadLine();
            int decimalNumber;

            if (int.TryParse(decimalInput, out decimalNumber))
            {
                if (decimalNumber >= 0 && decimalNumber <= int.MaxValue)
                {
                    string binaryOutput = DecimalToBinary(decimalNumber);
                    Console.WriteLine(binaryOutput);
                }
                else
                {
                    Console.WriteLine("The number is bigger than the maximum!");
                }
            }
            else
            {
                Console.WriteLine("Input whole number!");
            }
        }

        static string DecimalToBinary(int decimalNumber)
        {
            if (decimalNumber == 0) 
            {
                return "0";
            }

            string binary = "";
            while (decimalNumber > 0) 
            {
                binary = (decimalNumber % 2) + binary;
                decimalNumber /= 2;
            }
            return binary;
        }
    }
}
