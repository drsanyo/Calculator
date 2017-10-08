using System;
using System.Linq;

namespace Calculator
{
    public class MainClass
    {
        private static readonly string[] validOperators = { "+", "-", "*", "/" };

        public static void Main(string[] args)
        {            

            while (true)
            {
                try
                {
                    double firstNr = GetNumberFromConsole("first");
                    double secondNr = GetNumberFromConsole("second");
                    String operation = GetOperator();
                    double result = PerformCalculations(firstNr, secondNr, operation);

                    Console.WriteLine("result: " + result.ToString());                    
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error occured: " + e.Message);
                    Console.WriteLine("Please try again...");
                    Console.WriteLine("");
                }                
            }
        }

        public static double PerformCalculations(double firstNr, double secondNr, string operation)
        {
            double result = 0;
            switch (operation)
            {
                case "+":
                    result = Add(firstNr, secondNr);
                    break;
                case "-":
                    result = Minus(firstNr, secondNr);
                    break;
                case "*":
                    result = Multiply(firstNr, secondNr);
                    break;
                case "/":
                    result = Divide(firstNr, secondNr);
                    break;
                default:
                    result = 0;
                    break;
            }

            return result;
        }

        private static double GetNumberFromConsole(string argumentReadableName)
        {
            bool correctNumber = false;
            double argumentValue = 0;

            while (!correctNumber)
            {
                Console.WriteLine();
                Console.WriteLine("Enter {0} number or q to exit: ", argumentReadableName);
                string userInputValue = Console.ReadLine();
                CheckApplicationBreak(userInputValue);
                if (double.TryParse(userInputValue, out argumentValue))
                {
                    correctNumber = true;
                }
                else
                {
                    Console.WriteLine("Incorrect number *{0}*, please enter valid number", userInputValue);
                }
            }
            return argumentValue;
        }

        private static string GetOperator()
        {
            bool correctOperator = false;
            string operatorValue = "";

            while (!correctOperator)
            {
                Console.WriteLine();
                Console.WriteLine("Enter operator ({0}) or q to exit: ", string.Join(", ", validOperators));
                string userInputValue = Console.ReadLine();

                CheckApplicationBreak(userInputValue);
                if (IsOperatorValid(userInputValue))
                {
                    operatorValue = userInputValue;
                    correctOperator = true;
                }
                else
                {
                    Console.WriteLine("Invalid operator *{0}*, please enter valid operator ({1}) ", userInputValue, string.Join(", ", validOperators));
                }
            }
            return operatorValue;
        }        

        private static double Add(double firstNr, double secondNr)
        {
            return firstNr + secondNr;
        }

        private static double Minus(double firstNr, double secondNr)
        {
            return firstNr - secondNr;
        }

        private static double Multiply(double firstNr, double secondNr)
        {
            return firstNr * secondNr;
        }

        private static double Divide(double firstNr, double secondNr)
        {
            if (secondNr == 0)
            {
                throw new ArgumentException("Can not divide by 0");
            }

            return firstNr / secondNr;
        }        

        private static bool IsOperatorValid(string operatorValue)
        {
            bool isOpCorrect = validOperators.Contains(operatorValue);
            return isOpCorrect;
        }

        private static void CheckApplicationBreak(string userInputValue)
        {
            if (userInputValue.Equals("q"))
            {
                CloseApplication();
            }
        }

        private static void CloseApplication()
        {
            Console.WriteLine("Goodbye");
            Console.WriteLine("Press any key to close application...");
            Console.ReadKey();
            Environment.Exit(0);
        }

    }
}