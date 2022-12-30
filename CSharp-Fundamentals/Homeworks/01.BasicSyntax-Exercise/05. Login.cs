
using System;

namespace _05.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            var username = Console.ReadLine();
            char[] charArray = username.ToCharArray();
            Array.Reverse(charArray);
            var password = new string(charArray);
            var psw = string.Empty;

            var failCnt = 0;

            for (int i = 0; i <= 4; i++)
            {
                psw = Console.ReadLine();
                if (psw == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else
                {
                    failCnt++;
                    if (failCnt == 4)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        break;
                    }
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }                                
        }
    }
}
