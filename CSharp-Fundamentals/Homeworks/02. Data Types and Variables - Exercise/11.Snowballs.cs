using System;
using System.Numerics;

namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger snowballValue = 0;
            int snowballSnow = 0;
            int snowballTime = 0;
            int snowballQuality = 0;

            for (int i = 0; i < n; i++)
            {
                int currentSnowballSnow = int.Parse(Console.ReadLine());
                int currentSnowballTime = int.Parse(Console.ReadLine());
                int currentSnowballQuality = int.Parse(Console.ReadLine());

                if (currentSnowballTime == 0)
                {
                    continue;
                }

                BigInteger currentSnowballValue = BigInteger.Pow(currentSnowballSnow / currentSnowballTime, currentSnowballQuality);

                if (snowballValue <= currentSnowballValue)
                {
                    snowballValue = currentSnowballValue;
                    snowballSnow = currentSnowballSnow;
                    snowballTime = currentSnowballTime;
                    snowballQuality = currentSnowballQuality;
                }
            }
            Console.WriteLine($"{snowballSnow} : {snowballTime} = {snowballValue} ({snowballQuality})");
        }
    }
}
