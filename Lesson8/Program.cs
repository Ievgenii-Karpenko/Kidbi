using System;
using System.Diagnostics;
using System.IO;

namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                string path = @"C:\test\MyFile.txt";
                string copyPath = @"C:\test\CopyMyFile.txt";
                //File.Create(path);
                string content = "My name is Ievgenii";

                File.WriteAllText(path, content);

                if (!File.Exists(copyPath))  // !true = false; !false = true
                {
                    File.Copy(path, copyPath);
                }

                if (File.Exists(@"C:\test\MyFile2.txt"))
                {
                    File.Delete(@"C:\test\MyFile2.txt");
                }

                File.Move(@"C:\test\lalala.txt", @"C:\lalala.txt");

                string[] data = File.ReadAllLines(@"C:\test\Data.txt");

                string name = data[0];
                string surname = data[1];
                int age = Convert.ToInt32(data[2]);

                Console.WriteLine("My name is: " + name);
                Console.WriteLine("My surname is: " + surname);
                Console.WriteLine("My age is: " + age);

                string site = @"https://codeshare.io/5ZgBKe";
                string chrome = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe";

                ProcessStartInfo proces = new ProcessStartInfo(chrome, site);
                Process.Start(proces);

                // Створити програму, яка створює на диску С або D папку Homework і всередині цієї папки створює 
                // 7 окремих файлів з назвами HomeWork_1.txt, HomeWork_2.txt .. HomeWork_7.txt
                // Текст цих файлів: "This is the text of HomeWork_1"
                // Створення файлів має бути в циклі.
                // Не забути це все заключити в блоки try/catch з обробкою можливих помилок

                Directory.CreateDirectory("C:\\Classwork");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception is ocurred");
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
