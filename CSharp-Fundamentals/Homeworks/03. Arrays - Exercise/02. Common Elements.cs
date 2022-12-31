using System;
using System.Linq;

namespace _02.CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split();
            string[] arr2 = Console.ReadLine().Split();

            foreach (string arrTwo in arr2)
            {
                foreach (string arrOne in arr1)
                {
                    if (arrTwo == arrOne)
                    {
                        Console.Write(arrOne + " ");
                        break;
                    }
                }
            }
        }
    }
}
