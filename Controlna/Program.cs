// Andriy

// Створити два списки, один для імен людей, інший для їх віку (відповідно типу string та int).
// Запитати в користувача по черзі 5 імен записати ці значення в список імен (виконати це в циклі).
// Запитати в користувача по черзі вік для кожного імені записати ці значення в список віку (виконати це в циклі).
// Якщо введене число буде більше за 90 - згенерувати помилку.
// 
// Вивести на екран всі імена, які починаються на букву "V".
// Записати в файл всі числа зі списку віку, які більше 15.
// Розрахувати рік народження кожного з користувачів і також вивести роки народження на екран.

// *Реалізувати введення вхідної інформації шляхом зчитування з файлів
using System;
using System.Collections.Generic;
using System.IO;
namespace kr
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            List<int> ages = new List<int>();

            Console.WriteLine("Enter 5 names");
            for (int i = 0; i < 5; i++)
            {
                string name = Console.ReadLine();
                names.Add(name);
            }

            Console.WriteLine("Enter 5 ages");
            for (int i = 0; i < 5; i++)
            {
                int age = Convert.ToInt32(Console.ReadLine());

                if (age > 90)
                {
                    throw new Exception(" >90");
                }
                ages.Add(age);
            }

            for (int i = 0; i < names.Count; i++)
            {
                if (names[i].StartsWith("V"))
                {
                    Console.WriteLine(names[i]);
                }
            }

            string content = "";
            for (int i = 0; i < ages.Count; i++)
            {
                if (ages[i] > 15)
                {
                    content += ages[i] + "\n";
                }
            }

            File.WriteAllText(@"C:\test\ages.txt", content);

            for (int i = 0; i < ages.Count; i++)
            {
                {
                    int birthYear = 2021 - ages[i];
                    Console.WriteLine("You were born in the year of" + birthYear);
                }
            }
        }
    }
}
