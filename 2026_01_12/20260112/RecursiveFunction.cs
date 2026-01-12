using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20260112
{
    internal class RecursiveFunction
    {
        static void Main(string[] args)
        {
            // 재귀함수 - 자기 자신을 호출

            // 1부터 n까지의 합 구하기
            int sum = SumToN(10);
            Console.WriteLine("1 + 2 + 3 + ... + 10: " + sum);
        }

        // 1부터 n까지의 합 구하기
        static int SumToN(int n)
        {
            if (n <= 0)
            {
                return 0;
            }

            return n + SumToN(n - 1);
        }
    }
}
