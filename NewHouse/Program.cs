using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int numberOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

           

            double priceOfFlowers = 0;

            double discount = 0;

            if (flowerType == "Roses")
            {
                priceOfFlowers = 5;

                if (numberOfFlowers > 80)
                {
                   discount = 0.1;
                }
            }
            else if (flowerType == "Dahlias")
            {
                priceOfFlowers = 3.80;

                if (numberOfFlowers > 90) ;
                {
                    discount = 0.15;
                }
            }
            else if (flowerType == "Tulips")
            {
                priceOfFlowers = 2.80;

                if (numberOfFlowers > 80)
                {
                   discount = 0.15;
                }
            }
            else if (flowerType == "Narcissus")
            {
                priceOfFlowers = 3;

                if (numberOfFlowers < 120)
                {
                   discount = 0.15;
                }
            }
            else if (flowerType == "Gladiolus")
            {
                priceOfFlowers = 2.50;

                if (numberOfFlowers < 80)
                {
                   discount = 0.2;
                }
            }

            double totalPrice = numberOfFlowers * priceOfFlowers;
            double discountPrice = 0;

            if (flowerType == "Roses" || flowerType == "Dahlias" || flowerType == "Tulips")
            {
                discountPrice = totalPrice - (totalPrice * discount);
            }
            else if (flowerType == "Narcissus" || flowerType == "Gladiolus")
            {
                discountPrice = totalPrice + (totalPrice * discount);
            }

            if (discountPrice > budget)
            {
                double moneyNeeded = discountPrice - budget;
                Console.WriteLine($"Not enough money, you need {moneyNeeded:f2} leva more.");
            }
            else if (discountPrice <= budget)
            {
                double moneyLeft = budget - discountPrice;
                Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {flowerType} and {moneyLeft:f2} leva left.");
            }
        }
    }
}
