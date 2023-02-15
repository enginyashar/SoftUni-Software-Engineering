using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Filter_By_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> persons = new Dictionary<string, int>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] person = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string name = person[0];
                int age = int.Parse(person[1]);
                if (!persons.ContainsKey(name))
                {
                    persons.Add(name, 0);
                }
                persons[name] = age;
            }

            string filterType = Console.ReadLine();
            int filterValue = int.Parse(Console.ReadLine());
            string action = Console.ReadLine();


            foreach (var (personName, personAge) in persons.Where(x =>
                                                            {
                                                                if (filterType == "older")
                                                                {
                                                                    return x.Value >= filterValue;
                                                                }
                                                                else
                                                                {
                                                                    return x.Value < filterValue;
                                                                }
                                                            }))
            {
                if (action == "name age")
                {
                    Console.WriteLine($"{personName} - {personAge}");
                }
                else if (action == "name")
                {
                    Console.WriteLine(personName);
                }
                else
                {
                    Console.WriteLine(personAge);
                }
            }

        }

    }
}
