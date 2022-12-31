using System;

namespace _01._Integer_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNumm = int.Parse(Console.ReadLine());
            int foruthNum = int.Parse(Console.ReadLine());

            int result = (firstNum + secondNum) / thirdNumm * foruthNum;

            Console.WriteLine(result);
        }
    }
}
