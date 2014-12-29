using System;

using ClearMeasure.Library;

namespace ClearMeasure.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var utils = new CMUtilities();

            for (int i = 1; i <= 100; i++)
            {
                Console.Write(utils.GetOutput(i));
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
