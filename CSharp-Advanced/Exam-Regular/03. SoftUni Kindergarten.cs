using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniKindergarten
{
    public class Child
    {
        public Child(string firstName, string lastName, int age, string parentName, string contactNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            ParentName = parentName;
            ContactNumber = contactNumber;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string ParentName { get; set; }
        public string ContactNumber { get; set; }

        public override string ToString()
        {
            StringBuilder print = new StringBuilder($"Child: {FirstName} {LastName}, Age: {Age}, Contact info: {ParentName} - {ContactNumber}");
            return print.ToString().Trim();
        }
    }

    public class Kindergarten
    {
        public Kindergarten(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;

            Registry = new List<Child>();
        }

        public List<Child> Registry { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }

        public bool AddChild(Child child)
        {
            if (Registry.Count >= Capacity)
            {
                return false;
            }

            Registry.Add(child);
            return true;
        }

        public bool RemoveChild(string childFullName)
        {
            Child childToRemove = Registry.FirstOrDefault(c => $"{c.FirstName} {c.LastName}" == childFullName);

            if (childToRemove == null)
            {
                return false;
            }

            return Registry.Remove(childToRemove);
        }
        public int ChildrenCount
        {
            get { return Registry.Count; }
        }

        public Child GetChild(string childFullName)
        {
            return Registry.FirstOrDefault(c => $"{c.FirstName} {c.LastName}" == childFullName);
        }

        public string RegistryReport()
        {
            StringBuilder print = new StringBuilder();

            print.AppendLine($"Registered children in {Name}:");

            foreach (var child in Registry.OrderByDescending(c => c.Age).ThenBy(c => c.LastName).ThenBy(c => c.FirstName).ToList())
            {
                print.AppendLine(child.ToString());
            }
            return print.ToString().Trim();
        }
    }
    public class StartUp
    {
        static void Main(string[] args)
        {
            Kindergarten kindergarten = new Kindergarten("Space S", 8);

            Child childOne = new Child("Greta", "Garbo", 3, "Karl Gustafsson", "0468 888 888");
            Child childTwo = new Child("Elona", "Muskova", 4, "Maye Musk", " 1 888 518 3752");
            Child childThree = new Child("George", "Bush", 5, " George Bush Sr.", "xx xxx xxx xxx");
            Child childFour = new Child("Ruzha", "Ignatova", 6, "Veska Ignatova", "+49 30 901820");
            Child childFive = new Child("Greta", "Thinberg", 3, "Allen White", "541-754-3010");
            Child childSix = new Child("T", "Rex", 2, "Steven Spielberg", "63 001 09 93");
            Child childSeven = new Child("S", "Rex", 2, " Steven Spielberg ", "63 001 09 93");
            Child childEight = new Child("Greta", "Thunberg", 3, "Pablo Gaviria", "0888 888 888");
            Child childNine = new Child("Tim", "Duncan", 6, "William Duncan", "(555) 555-1234");

            Console.WriteLine(kindergarten.AddChild(childOne));
            // True
            Console.WriteLine(kindergarten.AddChild(childTwo));
            // True
            Console.WriteLine(kindergarten.AddChild(childThree));
            // True
            Console.WriteLine(kindergarten.AddChild(childFour));
            // True
            Console.WriteLine(kindergarten.AddChild(childFive));
            // True
            Console.WriteLine(kindergarten.AddChild(childSix));
            // True
            Console.WriteLine(kindergarten.AddChild(childSeven));
            // True
            Console.WriteLine(kindergarten.AddChild(childEight));
            // True
            Console.WriteLine(kindergarten.AddChild(childNine));
            // False

            Console.WriteLine(kindergarten.RemoveChild("Ruzha Ignatova"));
            // True
            Console.WriteLine(kindergarten.RemoveChild("George Bush"));
            // True
            Console.WriteLine(kindergarten.RemoveChild("Elona Muskova"));
            // True

            Console.WriteLine(kindergarten.RemoveChild("Ruzha Ignatova"));
            // False
            Console.WriteLine(kindergarten.RemoveChild("Tim Duncan"));
            // False

            Console.WriteLine(kindergarten.ChildrenCount);
            // 5

            Console.WriteLine(kindergarten.GetChild("S Rex"));
            //Child: S Rex, Age: 2, Contact info: Steven Spielberg - 63 001 09 93

            Console.WriteLine(kindergarten.RegistryReport());
            //Registered children in Space S:
            //Child: Greta Garbo, Age: 3, Contact info: Karl Gustafsson - 0468 888 888
            //Child: Greta Thinberg, Age: 3, Contact info: Allen White - 541-754-3010
            //Child: Greta Thunberg, Age: 3, Contact info: Pablo Gaviria - 0888 888 888
            //Child: S Rex, Age: 2, Contact info:  Steven Spielberg  - 63 001 09 93
            //Child: T Rex, Age: 2, Contact info: Steven Spielberg - 63 001 09 93


        }
    }
}
