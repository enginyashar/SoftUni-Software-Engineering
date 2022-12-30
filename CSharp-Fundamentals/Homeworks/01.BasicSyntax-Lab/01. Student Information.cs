using System;

namespace BasicFundamentalsStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());

            Name(name);
            Age(age);
            Grade(grade);
        }

        static void Name(string name)
        {            
            Console.Write($"Name: {name}, ");
        }
        static int Age(int age)
        {
            Console.Write($"Age: {age}, ");
            return age;
        }
        static double Grade(double grade)
        {
            Console.Write($"Grade: {grade:f2}");
            return grade;
        }
    }
}
