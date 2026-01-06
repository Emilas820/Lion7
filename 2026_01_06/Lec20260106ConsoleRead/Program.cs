using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec20260106ConsoleRead
{
    internal class ConsoleReadTest
    {
        static void Main(string[] args)
        {
            // Lecture 1: 사용자 입력을 문자열로 받기

            Console.Write("이름을 입력하세요: ");
            string name = Console.ReadLine();           //사용자로부터 입력 받기

            Console.WriteLine($"안녕하세요, {name}님!"); // 입력값 출력
        }
    }
}
