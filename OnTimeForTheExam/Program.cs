using System;

namespace OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arrivingHour = int.Parse(Console.ReadLine());
            int arrivingMinute = int.Parse(Console.ReadLine());

            int difference = 0;
            int hour = 0;
            int minutes = 0;

            examMinute += examHour * 60;
            arrivingMinute += arrivingHour * 60;

            if (arrivingMinute > examMinute)
            {
                Console.WriteLine("Late");
                difference = arrivingMinute - examMinute;
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes after the start");
                }
                else
                {
                    hour = difference / 60;
                    minutes = difference % 60;
                    Console.WriteLine($"{hour}:{minutes:d2} hours after the start");
                }
            }
            else if (arrivingMinute < examMinute - 30)
            {
                Console.WriteLine("Early");
                difference = examMinute - arrivingMinute;
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
                else
                {
                    hour = difference / 60;
                    minutes = difference % 60;
                    Console.WriteLine($"{hour}:{minutes:d2} hours before the start");
                }
            }
            else
            {
                Console.WriteLine("on time");
                difference = examMinute - arrivingMinute;
                Console.WriteLine($"{difference} minutes before the start");
            }
        }
    }
}
