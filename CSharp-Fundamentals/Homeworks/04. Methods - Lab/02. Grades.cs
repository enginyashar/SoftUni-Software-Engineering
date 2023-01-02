using System;

namespace _02.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            string print = string.Empty;

            Console.WriteLine(Number(grade, print));
        }
        static string Number(double grade, string print)
        {
            if (grade >= 2.00 && grade <= 2.99)
            {
                print = "Fail";
            }
            else if (grade >= 3.00 && grade <= 3.49)
            {
                print = "Poor";
            }
            else if (grade >= 3.50 && grade <= 4.49)
            {
                print = "Good";
            }
            else if (grade >= 4.50 && grade <= 5.49)
            {
                print = "Very good";
            }
            else if (grade >= 5.50 && grade <= 6.00)
            {
                print = "Excellent";
            }
            return print;
        }
    }
}
