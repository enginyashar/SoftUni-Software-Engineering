using System;
using System.Collections.Generic;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                string color = input[0];
                string[] clothes = input[1].Split(",");

                foreach (var wear in clothes)
                {
                    if (!wardrobe.ContainsKey(color))
                    {
                        wardrobe.Add(color, new Dictionary<string, int>());
                    }
                    if (!wardrobe[color].ContainsKey(wear))
                    {
                        wardrobe[color].Add(wear, 0);
                    }
                    wardrobe[color][wear]++;
                }                
            }

            string[] find = Console.ReadLine().Split();
            string lookingColor = find[0];
            string lookingWear = find[1];

            foreach (var (color, clothes) in wardrobe)
            {
                Console.WriteLine($"{color} clothes:");

                foreach (var (wear, count) in clothes)
                {
                    if (color == lookingColor && wear == lookingWear)
                    {
                        Console.WriteLine($"* {wear} - {count} (found!)");
                        continue;
                    }
                    Console.WriteLine($"* {wear} - {count}");
                }
            }
        }
    }
}
