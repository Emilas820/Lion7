using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_2026_01_05_String
{
    internal class StringTest
    {
        static void Main(string[] args)
        {
            // Lecture 9: String 형식 - 여러 문자를 저장
            string greeting = "Hello, World!";  // 문자열 저장
            string name = "Alice";              // 이름 저장

            Console.WriteLine(greeting);        // 출력 Hello, World!
            Console.WriteLine(name);            // 출력 Alice


            // Mission 9_1: 자료형 지정 후 출력

            char grade = 'A';                          
            char symbol = '★';              
            char number = '9';
            string playerName = "홍길동";
            string welcomeMessage = "게임에 오신 것을 환영합니다!";
            string emptystring = "";

            Console.WriteLine("** 실행 결과: **");
            Console.WriteLine("=== RPG 게임 ===");
            Console.WriteLine($"플레이어: {playerName}");
            Console.WriteLine($"등급: {grade} 등급 {symbol}");
            Console.WriteLine(welcomeMessage);

            // Mission 9_2: 숫자9, 문자 9

            // 숫자 9
            int number9 = 9;

            // 문자 '9'
            char character9 = '9';

            Console.WriteLine("=== 숫자 vs 문자 ===");
            Console.WriteLine($"숫자 9: {number9}");
            Console.WriteLine($"문자 '9': {character9}");

            int num = 9;          // 숫자 9
            char ch = '9';        // 문자 '9'

            Console.WriteLine("=== 값과 타입 비교 ===");
            Console.WriteLine($"숫자 변수: 값 = {num}, 타입 = {num.GetType()}");   // GetType() 메서드로 타입 확인
            Console.WriteLine($"문자 변수: 값 = {ch}, 타입 = {ch.GetType()}");     // GetType() 메서드로 타입 확인

            Console.WriteLine("\n=== 내부 저장 값(정수형 변환) 비교 ===");
            Console.WriteLine($"숫자 9의 정수값: {num}");
            // char를 int로 형변환하면 아스키 코드값이 나옵니다.
            Console.WriteLine($"문자 '9'의 실제 정수값(ASCII): {(int)ch}");        // {(변환하고 싶은 자료형)변수명}

            Console.WriteLine("\n=== 연산 결과 비교 ===");
            Console.WriteLine($"숫자 9 + 1 = {num + 1}");                                         // 출력 10
            Console.WriteLine($"문자 '9' + 1 = {(int)(ch + 1)} (문자 '9' 다음 문자의 코드값)");     // 출력 58
            Console.WriteLine($"문자 '9' + 1을 다시 문자로: {(char)(ch + 1)})");                   // 코드 58은 ':'
        }
    }
}
