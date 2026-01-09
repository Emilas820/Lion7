using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.InteropServices;

namespace Lec20260108Mission3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(100, 25); // 콘솔 창 크기 설정
            Console.SetBufferSize(100, 25); // 콘솔 창 크기와 동일하게 맞추어 스크롤 방지


            int playerRange = 0;

            const int Start = 20;

            int player = Start;

            Random random = new Random();
            int TargetA =0;
            int TargetB =0;

            while(TargetA == TargetB)
            {
                TargetA = random.Next(32, 80); // 적 세팅
                TargetB = random.Next(32, 80); // 적 세팅
            }

            bool isADead = false;
            bool isBDead = false;

            bool shoot = false;

            bool isGameStart = false;

            int BoomX = 0;
            int BoomY = 0;


            ConsoleKeyInfo keyInfo; // 키 입력값 받는 변수

            Console.CursorVisible = false; // 커서 지우기

            while(isGameStart == false)
            {
                Console.Write("아군 탱크의 사거리(10 - 30): ");
                playerRange = int.Parse(Console.ReadLine());
                isGameStart = true;
            }

            while (true)
            {
                Console.Clear(); // 화면 지우기

                // 지형
                Console.SetCursorPosition(0, 21);
                Console.Write("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
                Console.SetCursorPosition(0, 22);
                Console.Write("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
                Console.SetCursorPosition(0, 23);
                Console.Write("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");

                if(isADead == false)
                {
                    Console.SetCursorPosition(TargetA, 20); // 타겟A 좌표
                    Console.Write("A"); // 타겟 출력
                }
                if(isBDead == false)
                {
                    Console.SetCursorPosition(TargetB, 20); // 타겟B 좌표
                    Console.Write("B"); // 타겟 출력
                }

                Console.SetCursorPosition(player, 20); // 플레이어 좌표                
                Console.Write("●"); // 현재 위치 출력. WriteLine으로 출력 시 y축으로 무한대로 내려갈 수 있다...

                

                if (isADead == true && isBDead == true)
                {
                    // 게임 종료

                    Console.Clear(); 
                    Console.SetCursorPosition(Console.WindowWidth/2, 10);
                    Console.WriteLine("W I N");
                    Thread.Sleep(1000);
                    Environment.Exit(0);
                }


                    keyInfo = Console.ReadKey(true); // 키 입력 받는 중 . . .


                switch (keyInfo.Key)
                {
                    case ConsoleKey.LeftArrow: if (player > 0) player--; break;
                    case ConsoleKey.RightArrow: if (player < Console.WindowWidth - 1) player++; break;
                    case ConsoleKey.Spacebar: shoot = true; break;
                    case ConsoleKey.Escape: break;

                }

                if (shoot == true)
                {
                    int startX = player;
                    int endX = player + playerRange ; // 포탄이 날아갈 총 가로 거리
                    int startY = 20;        // 시작과 끝의 Y 높이
                    int maxHeight = 5;      // 포물선의 최대 높이 (위로 5칸)

                    // 포탄 이동 루프 (startX부터 endX까지 1칸씩 이동)
                    for (int x = startX; x <= endX; x++)
                    {
                        double progress = (double)(x - startX) / (endX - startX);
                        double yOffset = 4 * maxHeight * progress * (1 - progress);

                        int currentX = x;
                        int currentY = startY - (int)Math.Round(yOffset); // 반올림
                        // int currentY = startY - (int)yOffset; - 버림

                        // 3. 화면 밖으로 나가는 것 방지 및 출력
                        if (currentX >= 0 && currentX < Console.WindowWidth && currentY >= 0 && currentY < Console.WindowHeight)
                        {
                            Console.SetCursorPosition(currentX, currentY);
                            Console.Write("◎");
                        }

                        // 4. 충돌 판정 (이동 중에도 판정)
                        if (currentY == 20) // 바닥 높이에 도달했을 때
                        {
                            if (isADead == false && currentX == TargetA)
                            {
                                Console.SetCursorPosition(TargetA, 20);
                                Console.Write("펑");
                                isADead = true;
                                Thread.Sleep(200);
                            }
                            else if (isBDead == false && currentX == TargetB)
                            {
                                Console.SetCursorPosition(TargetB, 20);
                                Console.Write("펑");
                                isBDead = true;
                                Thread.Sleep(200);
                            }
                        }
                        Thread.Sleep(50); // 발사 속도 조절
                    }

                    shoot = false; // 발사 종료
                }

            }

        }
    }
}
