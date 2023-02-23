using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Queue<int> textiles = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
        Stack<int> medicaments = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

        Dictionary<string, int> items = new Dictionary<string, int>
        {
            ["MedKit"] = 100,
            ["Bandage"] = 40,
            ["Patch"] = 30
        };

        Dictionary<string, int> createdItems = new Dictionary<string, int>();
        bool textilesEmpty = false, medicamentsEmpty = false;

        while (textiles.Count > 0 && medicaments.Count > 0)
        {
            int sum = textiles.Peek() + medicaments.Peek();

            if (items.ContainsValue(sum))
            {
                string itemName = items.First(i => i.Value == sum).Key;
                createdItems[itemName] = createdItems.GetValueOrDefault(itemName) + 1;
                textiles.Dequeue();
                medicaments.Pop();
            }
            else if (sum > items["MedKit"])
            {
                createdItems["MedKit"] = createdItems.GetValueOrDefault("MedKit") + 1;
                int remaining = sum - items["MedKit"];
                medicaments.Pop();
                medicaments.Push(medicaments.Pop() + remaining);
            }
            else
            {
                textiles.Dequeue();
                medicaments.Push(medicaments.Pop() + 10);
                textilesEmpty = true;
            }
        }

        if (textiles.Count == 0)
        {
            Console.WriteLine("Textiles are empty.");
            textilesEmpty = true;
        }

        if (medicaments.Count == 0)
        {
            Console.WriteLine("Medicaments are empty.");
            medicamentsEmpty = true;
        }

        if (textilesEmpty && medicamentsEmpty)
        {
            Console.WriteLine("Textiles and medicaments are both empty.");
        }

        foreach (var item in createdItems.OrderByDescending(i => i.Value).ThenBy(i => i.Key))
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }

        if (medicaments.Count > 0)
        {
            Console.WriteLine($"Medicaments left: {string.Join(", ", medicaments)}");
        }

        if (textiles.Count > 0)
        {
            Console.WriteLine($"Textiles left: {string.Join(", ", textiles)}");
        }
    }
}
