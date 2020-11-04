using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            double spending = 0;
            string typeOfHolliday = "";

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    spending = 0.3;
                }
                else if (season == "winter")
                {
                    spending = 0.7;
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    spending = 0.4;
                }
                else if (season == "winter")
                {
                    spending = 0.8;
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                spending = 0.9;
            }

            if (season == "summer")
            {
                typeOfHolliday = "Camp";
                if (destination == "Europe")
                {
                    typeOfHolliday = "Hotel";
                }
            }
            else if (season == "winter")
            {
                typeOfHolliday = "Hotel";
            }

            double moneySpent = budget * spending;

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{typeOfHolliday} - {moneySpent:f2}");
        }
    }
}
