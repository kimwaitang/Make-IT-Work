using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        public static int count = 0;

        static void Main(string[] args)
        {
            // Reconize User input (+,-,/,*) and give result

            Console.WriteLine("Welcome to the calculator");
            Console.WriteLine(count);
            try
            {
                while (true)
                {
                    var ReadLine = Console.ReadLine();
                    string operation = ReadLine.Substring(0, 1);
                    int value = int.Parse(ReadLine.Substring(1));
                    switch (operation)
                    {
                        case "+":
                            count = Operations.Addition(value, count);
                            break;
                        case "-":
                            count = Operations.Minus(value, count);
                            break;
                        case "/":
                            count = Operations.Divide(value, count);
                            break;
                        case "*":
                            count = Operations.Multiply(value, count);
                            break;
                        default:
                            Console.WriteLine("This is not a valid operation");
                            break;
                    }
                }
            }
            catch (DivideByZeroException e) {
                Console.WriteLine("Can't divide by zero");
            }
            Console.ReadLine();
        }

    }
}
