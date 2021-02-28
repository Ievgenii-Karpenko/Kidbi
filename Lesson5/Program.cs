using System;
using System.Collections.Generic;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[5];

            Console.WriteLine("Element 1 = " + names[1]);
            Console.WriteLine("Element 6 = " + names[6]);

            Console.WriteLine("Please write user names:");

            names[0] = Console.ReadLine();
            names[1] = Console.ReadLine();
            names[2] = Console.ReadLine();
            names[3] = Console.ReadLine();
            names[4] = Console.ReadLine();

            for (int i = 0; i < names.Length; i++)
            {
                names[i] = Console.ReadLine();
            }

            Console.WriteLine("User names:");

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Element " + i + " = " + names[i]);
            }

            List<string> namesList = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                string name = Console.ReadLine();
                namesList.Add(name);
            }

            Console.WriteLine();
            Console.WriteLine("User names:");

            foreach (var item in namesList)
            {
                Console.WriteLine(item);
            }

            namesList.Sort();
            namesList.RemoveAt(3);

            Console.WriteLine();
            Console.WriteLine("Sorted user names:");
            foreach (var item in namesList)
            {
                Console.WriteLine(item);
            }

        }
    }
}
