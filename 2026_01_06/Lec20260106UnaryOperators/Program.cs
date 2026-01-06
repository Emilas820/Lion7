using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec20260106UnaryOperator
{
    internal class UnaryOperatorTest
    {
        static void Main(string[] args)
        {
            // Lecture 7: 단항 연산자
            int num = 5;
            Console.WriteLine(+num);
            Console.WriteLine(-num);

            bool flag = true;
            Console.WriteLine(!flag);
        }
    }
}
