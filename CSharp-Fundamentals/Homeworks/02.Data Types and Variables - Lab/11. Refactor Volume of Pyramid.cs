using System;

namespace _11.RefactorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double dul, sh, V = 0;

            Console.Write("Length: ");
            dul = double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            sh = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            V = double.Parse(Console.ReadLine());

            V = (dul * sh * V) / 3;

            Console.WriteLine($"Pyramid Volume: {V:f2}");
        }
    }
}
