using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace da
{
    class Program
    {
        static void Main(string[] args)
        {  Console.WriteLine("Напишите слово или число");
            string str = Console.ReadLine();
            bool g = true;
            int i, j = str.Length;
            for (i = 0; i < j / 2; i++)
             {
                if (str[i] != str[j - ( i + 1)])
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
