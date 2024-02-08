using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersice3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            string hexadecimal = DecimalToHexadecimal(number);

            Console.WriteLine(hexadecimal);
        }

        static string DecimalToHexadecimal(int number)
        {
            return Convert.ToString(number, 16).ToUpper();
        }
    }
}
