using System;
using System.Collections.Generic;


namespace ConsoleApp11
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Random rand = new Random();
            int value = rand.Next(0, 99);
            Console.WriteLine(value);
            int value1 = rand.Next(0, 99);
            Console.WriteLine(value1);
            int value2 = rand.Next(0, 99);
            Console.WriteLine(value2);
            int value2 = rand.Next(0, 99);
            Console.WriteLine(value2);


        }
    }
}
