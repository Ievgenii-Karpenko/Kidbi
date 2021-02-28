using System;

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number1;
            //Console.WriteLine("Please write number");
            //number1 = Convert.ToInt32(Console.ReadLine());
            //int fact = Factorial(number1);
            //Console.WriteLine("Result: "+ fact);

            //Console.WriteLine("Please write number 2");
            //number2 = Convert.ToInt32(Console.ReadLine());

            //int resultOfSum, resultOfDivision;
            //SumAndDivision(ref number1, number2, out resultOfSum, out resultOfDivision);

            //Console.WriteLine("Result of sum = " + resultOfSum);
            //Console.WriteLine("Result of division = " + resultOfDivision);

            //Console.WriteLine("Number 1 = " + number1);
            //Console.WriteLine("Number 2 = " + number2);

            double n1 = 12;
            double n2 = 0;
            double res;

            try
            {
                res = Division(n1, n2);
                Console.WriteLine("Result of division: " + res);
            }
            catch (Exception ex)
            {
                Console.WriteLine("We catched an exception");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("This is finnaly block!");
            }

            //double res = Sum(n1, n2);
            //double res2 = Sum(number1, number2);

            //Console.WriteLine("Res for double = " + res);
            //Console.WriteLine("Res for int = " + res2);

        }

        static void DisplayName()
        {
            Console.WriteLine("My name is Yevgenii");
        }

        static void DisplayGivenName(string name)
        {
            Console.WriteLine("My name is " + name);
        }

        static void SumAndDivision(ref int num1, int num2, out int resultSum, out int resultDivision)
        {
            resultSum = num1 + num2;
            resultDivision = num1 - num2;
        }

        static int Sum(int num1, int num2)
        {
            int rez = Sum(num1 + 1, num2 + 1);
            return rez + num2;
        }

        static double Sum(double num1, double num2)
        {
            return num1 + num2;
        }

        static double Division(double num1, double num2)
        {
            if (num2 == 0)
                throw new ArgumentException("Division by zero is forbidden!");

            return num1 / num2;
        }

        static int Factorial(int n)
        {
            if (n == 0)
                return 1;          

            if (n == 1)
                return 1;
            
            return n * Factorial(n - 1);
        }
    }
}
