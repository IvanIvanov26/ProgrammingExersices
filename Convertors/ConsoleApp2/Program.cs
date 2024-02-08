using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string binaryNumber = Console.ReadLine();
            int decimalNumber = BinaryToDecimal(binaryNumber);
            

            Console.WriteLine(decimalNumber);
        }
         static int BinaryToDecimal(string binaryNumber)
         {
            int decimalNumber = 0;
            int power = 0;

            for (int i = binaryNumber.Length - 1; i >= 0; i--)
            {
                int digit = int.Parse(binaryNumber[i].ToString());

                decimalNumber += digit * (int)Math.Pow(2, power);
                power++;
            }
            return decimalNumber;
         }
        
    }
}
