using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec20260106Binary
{
    internal class ConvertTest
    {
        static void Main(string[] args)
        {
            // Lecture 3: 2진수 - 10진수 변환

            Console.Write("2진수를 입력하세요: ");
            string binaryinput = Console.ReadLine();
            int decimalValue = Convert.ToInt32(binaryinput, 2);         // 2진수 정수를 10진수로 변환
            string binaryOutput = Convert.ToString(decimalValue, 2);    // 10진수 정수를 2진수로 변환

            Console.WriteLine($"입력한 이진수: {binaryinput}");
            Console.WriteLine($"10진수 변환: {decimalValue}");
            Console.WriteLine($"다시 2진수로 변환: {binaryOutput}");


            // Mission 3: 캐릭터 생성하기

            Console.WriteLine("=== 캐릭터 생성 ===");
            Console.Write("캐릭터 이름을 입력하세요: ");
            string UserName = Console.ReadLine();
            Console.WriteLine($"환영합니다, {UserName}님!");
            Console.Write("시작 레벨을 입력하세요: ");
            string UserLevel = Console.ReadLine();
            Console.WriteLine($"{UserName}님의 시작 레벨은 {UserLevel}입니다.");
        }
    }
}
