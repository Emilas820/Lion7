using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec20260105Parse
{
    internal class ParseTest
    {
        static void Main(string[] args)
        {
            // Lecture 2: 형식 변환하기

            Console.Write("나이를 입력하세요: ");
            string input = Console.ReadLine();
            int age = int.Parse(input);

            Console.WriteLine($"내년에는 {age+1}살이 되겠군요!");


            // 형식 변환 추가 설명


            // * 암시적 변환 (작은 타입 -> 큰 타입)
            int smallNumber = 100;
            long bigNumber = smallNumber; //int -> long(자동 변환)
            double doubleNumber = smallNumber; //int -> double(자동 변환)

            Console.WriteLine("=== 암시적 변환 ===");
            Console.WriteLine($"int: {smallNumber}, {smallNumber.GetType()}");
            Console.WriteLine($"long: {bigNumber}, {bigNumber.GetType()}");
            Console.WriteLine($"double: {doubleNumber}, {doubleNumber.GetType()}");

            // * 명시적 변환 (큰 타입 -> 작은 타입)
            double pi = 3.14159;
            int intpi = (int)pi; // 소수점을 버림(명시적 변환 필요)

            Console.WriteLine("\n=== 명시적 변환 ===");
            Console.WriteLine($"double: {pi}, {pi.GetType()}");
            Console.WriteLine($"int: {intpi}, {intpi.GetType()}");

            // * 문자열을 숫자로 변환
            string scoreText = "95";
            int score = int.Parse(scoreText); // 문자열 -> 정수

            string priceText = "19.99";
            double price = double.Parse(priceText); // 문자열 -> 실수

            Console.WriteLine("\n=== 문자열 변환 ===");
            Console.WriteLine($"점수(문자열): {scoreText}({scoreText.GetType()}) -> 숫자: {score}({score.GetType()})");
            Console.WriteLine($"가격(문자열): {priceText}({priceText.GetType()}) -> 숫자: {price}({price.GetType()})");

            // * 숫자를 문자열로 변환
            int playerLevel = 50;
            string levelText = playerLevel.ToString(); // 정수 -> 문자열

            Console.WriteLine("=== 숫자를 문자열로 ===");
            Console.WriteLine($"레벨(숫자): {playerLevel}({playerLevel.GetType()}) -> 문자열: {levelText}({levelText.GetType()})");


            // 1. 명시적 변환 시 데이터 손실
            double value = 9.8;
            int result = (int)value;  // 9.8 → 9 (소수점 버려짐!)

            // 2. 범위 초과
            int bigValue = 300;
            byte smallValue = (byte)bigValue;  // 오버플로우 발생!

            // 3. 잘못된 문자열 변환
            string text = "abc";
            // int num = int.Parse(text);  // ❌ 런타임 오류!

            // 안전한 변환: TryParse 사용
            if (int.TryParse(text, out int num))
            {
                Console.WriteLine($"변환 성공: {num}");
            }
            else
            {
                Console.WriteLine("변환 실패!");
            }
        }
    }
}
