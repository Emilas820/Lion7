using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20260112
{
    internal class FunctionTest
    {        static void Hello()
        {
            Console.WriteLine("안녕하세요");
        }
        static void Main(string[] args)
        {
            Hello();
            Console.WriteLine("\n밑에 함수를 불러볼까요~");

            SayHello(); // 재사용성 + 가독성

            Console.WriteLine("메뉴를 불러옵니다 . . .");

            // 함수 호출
            PrintSeparater();
            ShowGameStart();
            ShowGameEnd();


        }

        // 1단계 - 기본 함수

        static void SayHello()
        {
            Console.WriteLine("안녕하세요, 용사님");
            Console.WriteLine("모험을 시작합니다.");
        }

        static void ShowGameStart()
        {
            Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.WriteLine("┃         ⚔ RPG 게임 시작 ⚔         ┃");
            Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
        }

        static void PrintSeparater()
        {
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
        }

        static void ShowGameEnd()
        {
            Console.WriteLine("게임 종료");
        }
    }
}
