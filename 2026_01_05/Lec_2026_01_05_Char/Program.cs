using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_2026_01_05_Char
{
    internal class CharTest
    {
        static void Main(string[] args)
        {
            // Lecture 8: char 형식 - 단일 문자를 표현
            char letter = 'A';          // 문자 'A' 저장
            char symbol = '#';          // 특수 기호 저장
            char number = '9';          // 숫자 형태의 문자 저장 (문자 '9', 숫자 9 아님)

            Console.WriteLine(letter);  // 출력 A
            Console.WriteLine(symbol);  // 출력 #
            Console.WriteLine(number);  // 출력 9

            // Mission 8: 실수 타입 연습

            float SPD = 5.5f;
            double ASD = 1.25;
            decimal Cost = 12.99m;

            Console.WriteLine("=== 캐릭터 능력치 ===");
            Console.WriteLine($"이동속도: {SPD}");
            Console.WriteLine($"공격속도: {ASD}");
            Console.WriteLine($"아이템 가격: {Cost}");
        }
    }
}
