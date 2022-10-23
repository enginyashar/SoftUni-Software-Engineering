using System;

namespace _01.TheHuntingGames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int player = int.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());
            double water = double.Parse(Console.ReadLine()) * player * n;
            double food = double.Parse(Console.ReadLine()) * player * n;
            bool isThereEnergy = true;

            for (int i = 1; i <= n; i++)
            {
                double energyLoss = double.Parse(Console.ReadLine());
                energy -= energyLoss;

                if (energy <= 0)
                {
                    isThereEnergy = false;
                    Console.WriteLine($"You will run out of energy. You will be left with {food:f2} food and {water:f2} water.");
                    break;
                }

                if (i % 2 == 0 && water >= 0)
                {
                    water -= (water * 0.3);
                    energy *= 1.05;
                }

                if (i % 3 == 0 && food >= 0)
                {
                    food -= (food / player);
                    energy *= 1.1;
                }                
            }
            if (isThereEnergy)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {energy:f2} energy!");
            }
        }
    }
}
