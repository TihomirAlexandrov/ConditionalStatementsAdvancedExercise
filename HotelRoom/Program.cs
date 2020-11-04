using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int numberOfDays = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double apartmentPrice = 0;
            double studioDiscount = 0;
            double apartmentDiscount = 0;

            if (month == "May" || month == "October")
            {
                studioPrice = 50;
                apartmentPrice = 65;
                if (numberOfDays > 7 && numberOfDays <= 14)
                {
                    studioDiscount = 0.05;
                }
                else if (numberOfDays > 14)
                {
                    studioDiscount = 0.3;
                    apartmentDiscount = 0.1;
                }
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 75.20;
                apartmentPrice = 68.70;
                if (numberOfDays > 14)
                {
                    apartmentDiscount = 0.1;
                    studioDiscount = 0.2;
                }
            }
            else if (month == "July" || month == "August")
            {
                studioPrice = 76;
                apartmentPrice = 77;
                if (numberOfDays > 14)
                {
                    apartmentDiscount = 0.1;
                }
            }

            double discountStudioPrice = studioPrice - (studioPrice * studioDiscount);
            double discountApartmentPrice = apartmentPrice - (apartmentPrice * apartmentDiscount);
            double totalStudioPrice = discountStudioPrice * numberOfDays;
            double totalApartmentPrice = discountApartmentPrice * numberOfDays;

            Console.WriteLine($"Apartment: {totalApartmentPrice:f2} lv.");
            Console.WriteLine($"Studio: {totalStudioPrice:f2} lv.");
        }
    }
}
