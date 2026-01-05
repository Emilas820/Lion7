using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_2026_01_05_NumLiteral
{
    internal class NumLiteralTest
    {
        static void Main(string[] args)
        {
            // Lecture 7: 접미사 사용 - 숫자의 데이터 형식을 명시
            int intValue = 100;                 // 기본 정수형
            long longValue = 100L;              // 정수형 접미사 L
            float floatValue = 3.14f;           // 기본 실수형 접미사 f
            double doubleValue = 3.14;          // 실수형 접미사
            decimal decimalValue = 3.14m;       // 실수형 접미사 m

            Console.WriteLine(intValue);        // 출력 100
            Console.WriteLine(longValue);       // 출력 100
            Console.WriteLine(floatValue);      // 출력 3.14
            Console.WriteLine(doubleValue);     // 출력 3.14
            Console.WriteLine(decimalValue);    // 출력 3.14
        }
    }
}
