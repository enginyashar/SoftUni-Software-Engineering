using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double n50 = n * 0.5;
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int targetCnt = 0;            

            while (n >= m)
            {                
                if (n == n50)
                {
                    if (y > 0 && y <= 9)
                    {
                        n /= y;
                    }
                    else
                    {
                        n -= m;
                        targetCnt++;
                    }
                }

                if (n >= m)
                {
                    n -= m;
                    targetCnt++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(n);
            Console.WriteLine(targetCnt);
        }
    }
}
