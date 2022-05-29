using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //H.W from lesson 1

            Random r = new Random();
            int[] arr = new int[100];
            string path = @"numbers.txt";
            string numbers = "";
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(1, 100);
                numbers += $"{arr[i]} \t";
            }
            File.WriteAllText(path, numbers);

            Console.WriteLine(File.ReadAllText(path));

            string pathCsv = "text.csv";
            string[] text = new string[10];
            for (int i = 0; i < text.Length; i++)
            {
                text[i] = $"my nubers is, {r.Next(1, 100)}, {r.Next(1, 100)}, {r.Next(1, 100)}";
            }
            File.WriteAllLines(pathCsv, text);
            string[] newText = File.ReadAllLines(pathCsv);
            int a, b, c;
            string s;
            foreach (var t in newText)
            {
                //split the numbers from the text
                s = t.Split(',')[0];
                a = int.Parse(t.Split(',')[1]);
                b = int.Parse(t.Split(',')[2]);
                c = int.Parse(t.Split(',')[3]);
                Console.WriteLine($"{s}");
                Console.WriteLine($"{a},{b},{c}");
            }
            Console.WriteLine(File.ReadAllText(pathCsv));

            Console.ReadKey();
        }
    }
}
