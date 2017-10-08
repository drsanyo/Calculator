using System;

namespace Calculator
{
    class MainClass
    {
        public static void add(double firstNr, double secondNr)
        {
            double sum = firstNr + secondNr;
            Console.WriteLine("result: " + sum);
        }

        public static void minus(double firstNr, double secondNr)
        {
            double subtr = firstNr - secondNr;
            Console.WriteLine("result: " + subtr);
        }

        public static void multiply(double firstNr, double secondNr)
        {
            double mult = firstNr * secondNr;
            Console.WriteLine("result: " + mult);
        }

        public static void devide(double firstNr, double secondNr)
        {
            double division = firstNr / secondNr;
            if (!(secondNr == 0))
            {
                Console.WriteLine("result: " + division);
            }
            else
            {
                Console.WriteLine("can't devide by 0");
            }
        }

        public static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Enter first number");
                double firstNr = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number");
                double secondNr = double.Parse(Console.ReadLine());
                Console.WriteLine("Choose a function (*, /, +, - : )");
                String operation = Console.ReadLine();

                if (operation == "+")
                {
                    add(firstNr, secondNr);
                }
                else if (operation == "-")
                {
                    minus(firstNr, secondNr);
                }
                else if (operation == "*")
                {
                    multiply(firstNr, secondNr);
                }
                else if (operation == "/")
                {
                    devide(firstNr, secondNr);
                }
                else
                {
                    Console.WriteLine("klaida");
                }

                Console.WriteLine("To continue type anything, to quit press QUIT: ");
                String answer = Console.ReadLine();
                if (answer == "quit")
                {
                    Console.WriteLine("Goodbye");
                    break;
                }
            }
        }
    }
}