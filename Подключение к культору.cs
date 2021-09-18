using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
       public void Main(string[] args)
        {
            var cal = new calc();
            while (true)
            {
                var res = cal.Calculate(Console.ReadLine());
                Console.WriteLine(res);
            }
        }
    }
}