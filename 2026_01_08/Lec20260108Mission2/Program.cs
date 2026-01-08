using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec20260108Mission2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25); // 콘솔 창 크기 설정
            Console.SetBufferSize(80, 25); // 콘솔 창 크기와 동일하게 맞추어 스크롤 방지

            const int targetX = 50;
            const int targetY = 20;

            int x = 10, y = 10;

            ConsoleKeyInfo keyInfo; // 키 입력값 받는 변수

            Console.CursorVisible = false; // 커서 지우기

            while (true)
            {
                Console.Clear(); // 화면 지우기

                Console.SetCursorPosition(targetX, targetY); // 타겟 좌표
                Console.Write("★"); // 타겟 출력

                Console.SetCursorPosition(x, y); // 플레이어 좌표                
                Console.Write("●"); // 현재 위치 출력. WriteLine으로 출력 시 y축으로 무한대로 내려갈 수 있다...

                if (x == targetX && y == targetY)
                {
                    Console.Clear(); // 화면 지우기
                    Console.WriteLine("집에 도착했습니다.");
                    // 대충 대장장이 키우기 게임 연결 . . .
                }


                keyInfo = Console.ReadKey(true); // 키 입력 받는 중 . . .


                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow: if (y > 0) y--; break;  // 커서 위치 상한선 세팅
                    case ConsoleKey.DownArrow: if (y < Console.WindowHeight - 1) y++; break;
                    case ConsoleKey.LeftArrow: if (x > 0) x--; break;
                    case ConsoleKey.RightArrow: if (x < Console.WindowWidth - 1) x++; break;
                    case ConsoleKey.Spacebar: Console.Write("미사일키"); break;
                    case ConsoleKey.Escape: break;

                }


            }
        }
    }
}
