using System;

namespace _06.ForeignLanguages
{
    class Program
    {
        static void Main(string[] args)
        {
            var country = Console.ReadLine();
            string lang = "";

            if (country == "England" || country == "USA")
            {
                lang = "English";
            }
            else if (country == "Spain" || country == "Argentina" || country == "Mexico")
            {
                lang = "Spanish";
            }
            else
            {
                lang = "unknown";
            }
            Console.WriteLine(lang);
        }
    }
}
