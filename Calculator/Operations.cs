using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Operations
    {

        public static int Addition(int value, int count)
        {
            var _count = count + value;
            Console.WriteLine(_count);
            return 0;
        }

        public static int Minus(int value, int count)
        {
            var _count = count - value;
            Console.WriteLine(_count);
            return _count;
        }

        public static int Divide(int value, int count)
        {
            var _count = count / value;
            Console.WriteLine(_count);
            return _count;
        }

        public static int Multiply(int value, int count)
        {
            var _count = count * value;
            Console.WriteLine(_count);
            return _count;
        }
    }
}
