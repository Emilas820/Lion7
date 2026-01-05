using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_2026_01_05_Integer
{
    internal class IntegerTest
    {
        static void Main(string[] args)
        {
            // Lecture 3: 정수 데이터 형식: 소수점이 없는 숫자를 표현
            int intValue = -100;            // 4 bytes (32 bits)
            long longValue = 100000L;       // 8 bytes (64 bits)

            Console.WriteLine(intValue);    // 출력: -100
            Console.WriteLine(longValue);   // 출력: 100000
        }
    }
}
