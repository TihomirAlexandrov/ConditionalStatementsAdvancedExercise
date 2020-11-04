using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double ticketPrice = 0;

            switch (projection)
            {
                case "Premiere":
                    ticketPrice = 12;
                    break;
                case "Normal":
                    ticketPrice = 7.50;
                    break;
                case "Discount":
                    ticketPrice = 5;
                    break;
            }

            int cinemaCapacity = rows * columns;
            double income = cinemaCapacity * ticketPrice;

            Console.WriteLine($"{income:f2} leva");
        }
    }
}
