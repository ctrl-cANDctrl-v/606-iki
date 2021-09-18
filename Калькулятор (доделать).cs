using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ClassLibrary1
{

   

    public class Calculator
    {
        static void Main(string[] args)
        { }
        delegate int Operation(int a, int b);
        public int Calculate(string expression)
        {
            Operation operation = null;
            int? first = null;
            int? second = null;
            int mulFirst = 1;
            for (var i = 0; i < expression.Length; i++)
            {
                var ch = expression[i];
                switch (ch)
                {
                    case '+':
                        {
                            if (i == 0)
                            {
                                continue;
                            }
                            operation = Add;
                        }
                        break;
                    case '-':
                        {
                            if (i == 0)
                            {
                                mulFirst = -1;
                                continue;
                            }

                            operation = Sub;
                        }break;

                    default:
                        {
                            string str = "";
                            do
                            {
                                if (!char.IsDigit(ch))
                                {
                                    throw new Exception("Not a number");
                                }
                                str += ch;

                                if (i + 1 >= expression.Length)
                                {
                                    break;
                                }
                                if (!char.IsDigit(expression[i + 1]))
                                { break; }

                                i++;
                                ch = expression[i];
                                continue;

                            } while (true);

                            var tmp = int.Parse(str);

                            if (!first.HasValue)
                            {
                                first = tmp * mulFirst;
                                break;
                            }

                            second = tmp * mulFirst;
                            }
                            break;
                        }

                        if (first.HasValue
                            && second.HasValue
                            && operation != null)
                        {
                            first = operation(first.Value, second.Value);
                            operation = null;
                            second = null;
                         }
                       }

                return first.Value;
              }

  

        private int Add(int a, int b)
        {
            return a + b;
        }


        private int Sub(int a, int b)
        {
            return a - b;
        }

        
    }
}


