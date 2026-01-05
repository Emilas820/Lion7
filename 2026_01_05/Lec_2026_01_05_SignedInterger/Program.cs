using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_2026_01_05_SignedInterger
{
    internal class SignedIntergerTest
    {
        static void Main(string[] args)
        {
            // Lecture 4: 부호 있는 정수 - 음수와 양수를 모두 표현 가능
            sbyte signedByte = -50;         //1byte
            short signedShort = -32000;     //2byte
            int signedInt = -2000000000;    //4byte

            Console.WriteLine(signedByte);  // 출력: -50
            Console.WriteLine(signedShort); // 출력: -32000
            Console.WriteLine(signedInt);   // 출력: -2000000000
        }
    }
}
