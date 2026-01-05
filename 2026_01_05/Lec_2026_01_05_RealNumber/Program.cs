using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_2026_01_05_RealNumber
{
    internal class RealNumberTest
    {
        static void Main(string[] args)
        {
            // Lecture 6: 실수 데이터 형식 - 소수점을 포함한 숫자를 표현
            float singlePrecision = 3.14f;                              // 단정밀도 실수 4byte, "f" 접미사 필요
            double doublePrecision = 3.1415926535;                      // 배정밀도 실수 8byte
            decimal highPrecision = 3.1415926535897932384626433833m;    // 고정밀도 실수 16byte, "m" 접미사 필요

            Console.WriteLine(singlePrecision);                         // 출력 3.14
            Console.WriteLine(doublePrecision);                         // 출력 3.1415926535
            Console.WriteLine(highPrecision);                           // 출력 3.1415926535897932384626433833
        }
    }
}
