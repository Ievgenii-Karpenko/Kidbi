using System;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please choose the door");
            string choice = "";

            string rnd = new Random().Next(0, 6).ToString();

            while (choice != "exit")
            {
                choice = Console.ReadLine();
                if(choice == rnd)
                {
                    Console.WriteLine("You chose the door with treasure!!! Congratulation");
                }
                else if (choice == "1")
                {
                    Console.WriteLine("You chose the door with enemy");
                }
                else if (choice == "3")
                {
                    Console.WriteLine("OMG! It is COVID-19");
                }
                else if (choice == "4" || choice =="5" || choice == "2")
                {
                    Console.WriteLine("This is empty door");
                }
                else if (choice == "exit")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("There is no such door");
                }

                Console.WriteLine();
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Please choose another door");
            }


        }
    }
}
