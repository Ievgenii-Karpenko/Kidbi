using System;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isAlive = false;

            if (isAlive)
            {
                Console.WriteLine("Player is alive");
            }
            else
            {
                Console.WriteLine("Player is dead :(");
            }

            bool fullHP = false, fullAmmo = false;

            if (fullHP || fullAmmo)
            {
                Console.WriteLine("Player has fullHP or FullAmmo");
            }

            // != - не рівність
            // == - рівність значень
            // || - логічне "або"
            // && - логічне "і"
            // >  - більше
            // <  - менше
            // >= - більше рівне
            // <= - менше рівне

            int day, month, year;
            Console.WriteLine("Please write a date");
            day = Convert.ToInt32(Console.ReadLine());
            month = Convert.ToInt32(Console.ReadLine());
            year = Convert.ToInt32(Console.ReadLine());

            int currentYear = 2021;

            if (day == 1 && month == 1 && year == currentYear)
            {
                Console.WriteLine("Happy New Year!!! Xo-xo-xo");
            }
            else
            {
                Console.WriteLine("Sorry, go to school ^_^");
            }



            if (year > currentYear)
            {
                Console.WriteLine("This is the future year");
            }
            else if (year < currentYear)
            {
                Console.WriteLine("This is the past year");
            }
            else if (year == currentYear)
            {
                Console.WriteLine("This is the current year");
            }

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Please choose the door");
            
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("You chose the door with treasure!!! Congratulation");
                    break;
                case "2":
                    Console.WriteLine("You chose the door with enemy");
                    break;
                case "3":
                case "4":
                case "5":
                    Console.WriteLine("This is empty door");
                    break;
                default:
                    Console.WriteLine("There is no such door");
                    break;
            }

            Console.WriteLine("--------------------------------------------");
        }
    }
}
