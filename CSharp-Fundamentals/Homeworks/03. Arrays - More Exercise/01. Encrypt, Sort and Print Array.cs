using System;

namespace _01.EncryptSortAndPrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                int vowelSum = 0;
                int consonantSum = 0;

                for (int j = 0; j < name.Length; j++)
                {                    
                    char currLetter = name[j];

                    switch (currLetter)
                    {
                        case 'A':
                        case 'a':
                        case 'E':
                        case 'e':
                        case 'O':
                        case 'o':
                        case 'U':
                        case 'u':
                        case 'I':
                        case 'i':
                            vowelSum += currLetter * name.Length;
                            break;
                        default:
                            consonantSum += currLetter / name.Length;
                            break;
                    }
                }
                int sum = vowelSum + consonantSum;
                arr[i] = sum;
            }

            Array.Sort(arr);
            Console.WriteLine(string.Join("\n", arr));
        }
    }
}
