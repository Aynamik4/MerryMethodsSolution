// Ugh!

using System;
using System.Collections.Generic;

namespace MerryMethodsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodBench methodBench = new MethodBench();

            int count = 0;
            do
            {
                count++;
                methodBench.FirstMethod();
            } while (count < 3);

            methodBench.SecondMethod("C# Now and Forever");
            Console.Write("Enter something: ");
            string input = Console.ReadLine();
            methodBench.SecondMethod(input);

            Console.Write("[U] to print in upper case, otherwise lower case: ");
            bool upper = Console.ReadKey(false).Key == ConsoleKey.U;
            Console.WriteLine();
            methodBench.ThirdMethod(input, upper);

            bool shout = methodBench.FourthMethod();
            methodBench.ThirdMethod(input, shout);
            methodBench.ThirdMethod(input, methodBench.FourthMethod());

            var x = methodBench.SixthMethod();

            if(x.LengthyName)
                Console.WriteLine($"\"{x.Name}\" is a lengthy name.");
            else
                Console.WriteLine($"\"{x.Name}\" is not a lengthy name.");
        }
    }
}