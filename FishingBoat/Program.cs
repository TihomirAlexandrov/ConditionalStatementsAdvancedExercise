using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numberOfPeople = int.Parse(Console.ReadLine());
            double discount = 0;
            int priceOfBoat = 0;

            if (season == "Spring")
            {
                priceOfBoat = 3000;
                if (numberOfPeople <= 6)
                {
                    discount = 0.1;
                }
                else if (numberOfPeople > 6 && numberOfPeople <= 11)
                {
                    discount = 0.15;
                }
                else if (numberOfPeople > 11)
                {
                    discount = 0.25;
                }
            }
            else if (season == "Summer" || season == "Autumn")
            {
                priceOfBoat = 4200;
                if (numberOfPeople <= 6)
                {
                    discount = 0.1;
                }
                else if (numberOfPeople > 6 && numberOfPeople <= 11)
                {
                    discount = 0.15;
                }
                else if (numberOfPeople > 11)
                {
                    discount = 0.25;
                }
            }
            else if (season == "Winter")
            {
                priceOfBoat = 2600;
                if (numberOfPeople <= 6)
                {
                    discount = 0.1;
                }
                else if (numberOfPeople > 6 && numberOfPeople <= 11)
                {
                    discount = 0.15;
                }
                else if (numberOfPeople > 11)
                {
                    discount = 0.25;
                }
            }

            double secondDiscount = 0;
            if (numberOfPeople % 2 == 0 && season != "Autumn")
            {
                secondDiscount = 0.05;
            }

            double sum = priceOfBoat - (priceOfBoat * discount);
            double finalSum = sum - (sum * secondDiscount);
            double moneyNeeded = finalSum - budget;
            double moneyLeft = budget - finalSum;

            if (budget >= finalSum)
            {
                Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
            }
            else if (budget < finalSum)
            {
                Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva.");
            }
        }
    }
}
