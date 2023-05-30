using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn
{
    class Operations
    {
        public static void Main(string[] args)
        {
            Operations op = new Operations();
            Console.WriteLine(op.addnum(10, 10));
        }
        public int addnum(int a, int b)
        {
            return a + b;
        }
        public int subnum(int a , int b)
        {
            return a - b;
        }
        public int mulnum(int a, int b)
        {
            return a * b;
        }
        public int divnum(int a, int b)
        {
            return a / b;
        }
    }
}
