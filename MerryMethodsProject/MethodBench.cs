using System;
using System.Collections.Generic;
using System.Text;

namespace MerryMethodsProject
{
    class MethodBench
    {
        public void FirstMethod()
        {
            Console.WriteLine("Merry Methods");
        }

        public void SecondMethod(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine();
        }

        public void ThirdMethod(string message, bool versaler)
        {
            if (versaler)
                message = message.ToUpper();
            else
                message = message.ToLower();

            SecondMethod(message);
        }

        public bool FourthMethod()
        {
            bool validKey = false;
            ConsoleKey key = ConsoleKey.A;

            while (!validKey)
            {
                Console.Write("Would you like to [W]hisper or [S]hout?: ");
                key = Console.ReadKey(false).Key;
                validKey = (key == ConsoleKey.W) || (key == ConsoleKey.S);
            }

            Console.WriteLine();
            return key == ConsoleKey.S;
        }

        public (string Name, bool Shout) WhosSounding()
        {
            Console.Write("Please type your name: ");
            return (Console.ReadLine(), FourthMethod());
        }

        public (string Name, bool LengthyName) SixthMethod()
        {
            Console.Write("Please type a name (any name): ");
            string s = Console.ReadLine();
            bool longName = s.Length > 5;
            return (s, longName);
        }
    }
}