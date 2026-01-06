using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec20260106Operator
{
    internal class POperatorTest
    {
        static void Main(string[] args)
        {
            // Lecture 6: 연산자

            int a = 5, b = 3;
            int sum = a + b;            // 산술 연산자
            bool isEqual = (a == b);    // 관계형 연산자

            Console.WriteLine($"합: {sum}");
            Console.WriteLine($"a와 b가 같은가? {isEqual}");

        }
    }
}
