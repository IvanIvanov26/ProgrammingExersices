using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int num = Convert.ToInt32(Console.ReadLine());
            string binary = ConvertToBinary(num);
            Console.WriteLine(binary);
        }

        static string ConvertToBinary(int num)
        {
            return Convert.ToString(num, 2);
        }
    }
}
