using System;
using System.Text;

namespace _05._Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            StringBuilder decrypt = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                char ch = char.Parse(Console.ReadLine());

                decrypt.Append((char)(ch + key));
            }
            Console.WriteLine(decrypt);
        }
    }
}
