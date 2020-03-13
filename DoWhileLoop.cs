﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandboxConsole
{
    class DoWhileLoop
    {
        static void Main(string[] arg)
        {
            do
            {
                Console.WriteLine("Please enter the value to start from");
                int valToStart = 0;
                Int32.TryParse(Console.ReadLine(), out valToStart);

                Console.WriteLine("Please enter the value to end with");
                int valToEnd = 0;
                Int32.TryParse(Console.ReadLine(), out valToEnd);

                if (valToStart < valToEnd)
                {
                    Console.WriteLine("Following is the result");

                    for (int i = valToStart; i <= valToEnd; i++)
                    {
                        Console.WriteLine(i);
                    }
                }
                else
                    Console.WriteLine("End value must be bigger than start value. Please try again.");
            }
            while (true);
        }
    }
}
