using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_2026_01_05_UnsignedInterger
{
    internal class UnsignedIntergerTest
    {
        static void Main(string[] args)
        {
            // Lecture 5: 부호가 없는 정수: 0 이상의 정수만 표현 가능
            byte unsignedByte = 255;            // 1byte
            ushort unsignedShort = 65000;       // 2byte
            uint unsignedInt = 4000000000;      // 4byte

            Console.WriteLine(unsignedByte);    // 출력: 255
            Console.WriteLine(unsignedShort);   // 출력: 65000
            Console.WriteLine(unsignedInt);     // 출력: 4000000000
        }
    }
}
