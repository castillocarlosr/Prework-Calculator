using System;

namespace Prework_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Simple Console Calcuator by Carlos Castillo");
            Console.WriteLine("\n");
            Console.WriteLine("Choose an opertation you would like perform: ");
            Console.WriteLine("1) Addition");
            Console.WriteLine("2) Subtration");
            Console.WriteLine("3) Multiply");
            Console.WriteLine("4) Divide");
            Console.WriteLine("5) Exit");
            string result = Console.ReadLine();
            if (result == "1")
            {
                Addition();
                return true;
            }
            else if (result == "2")
            {
                Subtraction();
                return true;
            }
            else if (result == "3")
            {
                //multiply
                return true;
            }
            else if (result == "4")
            {
                //Divide
                return true;
            }
            else if (result == "5")
            {
                return false;
            }
            else
            {
                //OtherKeyPressed();
                return true;
            }
        }

        private static void Addition()
        {
            Console.Clear();
            Console.WriteLine("Addition of two integers.");
            int x;
            int y;
            Console.Write("Enter your first number:   ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter your second number:  ");
            y = int.Parse(Console.ReadLine());

            int addResult = x + y;
            Console.WriteLine("\n");
            Console.WriteLine(addResult);
            Console.ReadLine();
        }

        private static void Subtraction()
        {
            Console.Clear();
            Console.WriteLine("Subtraction of two integers.");
            int x;
            int y;
            Console.Write("Enter your first number:       ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter your second number:  ");
            y = int.Parse(Console.ReadLine());

            int subtractResult = x - y;
            Console.WriteLine("\n");
            Console.WriteLine(subtractResult);
            Console.ReadLine();
        }

        private static void Multiplication()
        {
            Console.Clear();
            Console.WriteLine("")
        }
    }
}
