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
            String path = @"C:\\test.txt";
            string[] readText = File.ReadAllLines(path);
            bool g = true;
            int i, j = str.Length;
            for (i = 0; i < j / 2; i++)
            {
                if (str[i] != str[j - (i + 1)])
                {
                    g = false;
                    break;
                }
            }

            if (g)
                Console.WriteLine("Является палиндромом");
            else
                Console.WriteLine("Не является палиндромом");
            Console.ReadLine();
        }
    }
}
