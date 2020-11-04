using System;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();

            double result = 0;
            string evenOdd = "";

            if (symbol == "+")
            {
                result = num1 + num2;
                if (result % 2 == 0)
                {
                    evenOdd = "even";
                }
                else
                {
                    evenOdd = "odd";
                }
            }
            else if (symbol == "-")
            {
                result = num1 - num2;
                if (result % 2 == 0)
                {
                    evenOdd = "even";
                }
                else
                {
                    evenOdd = "odd";
                }
            }
            else if (symbol == "*")
            {
                result = num1 * num2;
                if (result % 2 == 0)
                {
                    evenOdd = "even";
                }
                else
                {
                    evenOdd = "odd";
                }
            }
            else if (symbol == "/")
            {
                result = num1 / num2;
                
            }
            else if (symbol == "%")
            {
                result = num1 % num2;
            }


            if (symbol == "+" || symbol == "-" || symbol == "*")
            {
                Console.WriteLine($"{num1} {symbol} {num2} = {result} - {evenOdd}");
            }
            else if (symbol == "/")
            {
                if (num2 == 0)
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
                else
                {
                    Console.WriteLine($"{num1} / {num2} = {result:f2}");
                }
            }
            else if (symbol == "%")
            {
                if (num2 == 0)
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
                else
                {
                    Console.WriteLine($"{num1} % {num2} = {result}");
                }
            }
        }
    }
}
