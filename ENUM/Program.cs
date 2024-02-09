using System;

public class Program
{
    enum DaysOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    public static void Main(string[] args)
    {
        DaysOfWeek today = DaysOfWeek.Monday;

        if (today == DaysOfWeek.Saturday || today == DaysOfWeek.Sunday)
        {
            Console.WriteLine("It's the weekend!");
        }
        else
        {
            Console.WriteLine("It's a weekday.");
        }

        switch (today)
        {
            case DaysOfWeek.Monday:
                Console.WriteLine("Back to work!");
                break;
            case DaysOfWeek.Friday:
                Console.WriteLine("TGIF!");
                break;
            default:
                Console.WriteLine("Just another day...");
                break;
        }
        Console.ReadLine();
    }

}
