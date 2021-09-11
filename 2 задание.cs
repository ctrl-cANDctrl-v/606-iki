using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace da
{
    class Program
    {
        static void Main(string[] args)
        {
            String path = @"C:\Users\528-19\Desktop\test.txt";
            string[] readText = File.ReadAllLines(path);
            foreach (string s in readText)
            {
                Console.WriteLine(s);
                bool g = true;
                int i, j = s.Length;
                for (i = 0; i < j / 2; i++)
                {
                    if (readText[i] != readText[j - (i + 1)])
                    {
                        g = false;
                        break;
                    }
                }

                if (g)
                    Console.WriteLine("Является палиндромом");
                else
                    Console.WriteLine("Не является палиндромом");
                //Console.ReadLine();
            }
        }
    }
}
