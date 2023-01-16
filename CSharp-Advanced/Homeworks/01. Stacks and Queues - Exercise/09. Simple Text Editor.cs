using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<string> undos = new Stack<string>();
            StringBuilder text = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int command = int.Parse(tokens[0]);

                switch (command)
                {
                    case 1:
                        undos.Push(text.ToString());
                        string txt = string.Join(" ", tokens.Skip(1));
                        text.Append(txt);
                        break;
                    case 2:
                        undos.Push(text.ToString());
                        int count = int.Parse(tokens[1]);
                        if (text.Length >= count)
                        {
                            text.Remove(text.Length - count, count);
                        }
                        else
                        {
                            text.Clear();
                        }
                        break;
                    case 3:
                        int index = int.Parse(tokens[1]) - 1;
                        Console.WriteLine(text[index]);
                        break;
                    case 4:
                        text = new StringBuilder(undos.Pop());
                        break;
                }
            }
        }
    }
}
