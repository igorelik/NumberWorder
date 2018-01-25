using System;
using System.Collections.Generic;
using NumberWordAPI;

namespace NumberWorder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers in format 1234_5678, or 12 34 56 78, etc. Enter to end");
            var converter = new NumberConverter();
            var inputString = "";
            do
            {
                Console.Write("Number:");
                inputString = Console.ReadLine();
                converter.AddRowString(inputString);
            } while (inputString != "");
            Console.WriteLine(converter.ToString());
            Console.WriteLine("----------------->> Press enter to exit");
            Console.ReadLine();
        }

    }
}
