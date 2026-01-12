using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20260112
{
    internal class ref_2
    {
        // ref 실습
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            int temp;

            // swap 두 개의 변수의 값을 바꿔주기.

            temp = x;
            x = y;
            y = temp;

            Console.WriteLine($"x: {x}, y: {y}\n");

            // swaper1
            Swaper1(x, y);
            Console.WriteLine($"x: {x}, y: {y}\n");

            // swaper2
            Swaper2(ref x, ref y);
            Console.WriteLine($"x: {x}, y: {y}\n");
        }

        // 일반 함수
        static void Swaper1(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        // ref 함수
        static void Swaper2(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
