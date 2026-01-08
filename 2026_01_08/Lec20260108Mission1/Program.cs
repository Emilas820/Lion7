using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.ComponentModel.Design;
using System.Xml;

namespace Lec20260108Mission1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mission - 대장장이 키우기 게임 개선하기

            Random rand = new Random();
            Console.CursorVisible = false; // 커서 지우기

            Console.WriteLine("\n=== 대장장이 키우기 ===");

            int pmoney = 0;
            int input;
            string back;
            int rnd;

            // 보유 장비 개수
            int SSS = 0;
            int SS = 0;
            int S = 0;
            int A = 0;
            int B = 0;
            int C = 0;

            // 무한반복
            while (true)
            {
                Console.Clear(); // 화면 지우기
                Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━┓");
                Console.WriteLine("┃   대장장이 키우기   ┃");
                Console.WriteLine("┃                     ┃");
                Console.WriteLine("┃     1.나무 캐기     ┃");
                Console.WriteLine("┃     2.장비 뽑기     ┃");
                Console.WriteLine("┃     3.보관함        ┃");
                Console.WriteLine("┃     4.게임 종료     ┃");
                Console.WriteLine("┃                     ┃");
                Console.WriteLine(" ");
                Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━┛");
                Console.SetCursorPosition(0, 8);

                Console.Write("┃입력:                ┃");
                Console.SetCursorPosition(7, 8);

                input = int.Parse(Console.ReadLine()); // input에 키로 눌린 숫자 담기

                if (input == 1) // 나무 캐기
                {
                    // UI 세팅

                    Console.Clear(); // 화면 지우기
                    Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━┓");
                    Console.WriteLine("┃                     ┃");
                    Console.WriteLine("┃      나무 캐기      ┃");
                    Console.WriteLine("┃                     ┃");
                    Console.WriteLine("┃                     ┃");
                    Console.WriteLine("┃                     ┃");
                    Console.WriteLine("┃                     ┃");
                    Console.WriteLine("┃                     ┃");
                    Console.WriteLine("┃                     ┃");
                    Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━┛");
                    
                    bool loggingStart = true;

                    while (true)
                    {
                        
                        if (loggingStart == true)
                        {
                            Console.SetCursorPosition(4, 4);
                            Console.WriteLine("나무 캐기 (Enter)");
                            loggingStart =false;
                        }
                        
                        string str = Console.ReadLine();
                        // UI 세팅

                        Console.Clear(); // 화면 지우기
                        Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━┓");
                        Console.WriteLine("┃                     ┃");
                        Console.WriteLine("┃                     ┃");
                        Console.WriteLine("┃                     ┃");
                        Console.WriteLine("┃                     ┃");
                        Console.WriteLine("┃                     ┃");
                        Console.WriteLine("┃                     ┃");
                        Console.WriteLine("┃                     ┃");
                        Console.WriteLine("┃                     ┃");
                        Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━┛");

                        rnd = rand.Next(1, 101);

                        if (str == "x")
                        {
                            Console.WriteLine("뒤로가기");
                            break;
                        }

                        if (rnd >= 90)
                        {
                            Console.SetCursorPosition(4, 4);
                            Console.Write(" 영    -    ");
                            Thread.Sleep(500);
                            Console.Write("차");
                            Thread.Sleep(500);
                            Console.SetCursorPosition(5, 2);
                            Console.WriteLine("튼튼한 통나무");
                            Console.SetCursorPosition(6, 3);
                            Console.WriteLine(" + 500 G ");
                            Console.SetCursorPosition(2, 4);
                            pmoney += 500;
                            Console.WriteLine($" 현재 골드: {pmoney} G ");
                            Console.SetCursorPosition(4,6);
                            Console.WriteLine(" 계속 - Enter");
                            Console.SetCursorPosition(4, 7);
                            Console.WriteLine(" 나가기 - X");
                            Console.SetCursorPosition(0, 10);

                        }
                        else if (rnd < 90 && rnd > 10)
                        {
                            Console.SetCursorPosition(4, 4);
                            Console.Write(" 영    -    ");
                            Thread.Sleep(500);
                            Console.Write("차");
                            Thread.Sleep(500);
                            Console.SetCursorPosition(5, 2);
                            Console.WriteLine("무난한 통나무");
                            Console.SetCursorPosition(6, 3);
                            Console.WriteLine(" + 100 G ");
                            Console.SetCursorPosition(2, 4);
                            pmoney += 100;
                            Console.WriteLine($" 현재 골드: {pmoney} G ");
                            Console.SetCursorPosition(4, 6);
                            Console.WriteLine(" 계속 - Enter");
                            Console.SetCursorPosition(4, 7);
                            Console.WriteLine(" 나가기 - X");
                            Console.SetCursorPosition(0, 10);
                        }
                        else
                        {
                            Console.SetCursorPosition(4, 4);
                            Console.Write(" 영    -    ");
                            Thread.Sleep(500);
                            Console.Write("차");
                            Thread.Sleep(500);
                            Console.SetCursorPosition(5, 2);
                            Console.WriteLine("부패한 통나무");
                            Console.SetCursorPosition(6, 3);
                            Console.WriteLine(" + 0 G ");
                            Console.SetCursorPosition(2, 4);

                            Console.WriteLine($" 현재 골드: {pmoney} G ");
                            Console.SetCursorPosition(4, 6);
                            Console.WriteLine(" 계속 - Enter");
                            Console.SetCursorPosition(4, 7);
                            Console.WriteLine(" 나가기 - X");
                            Console.SetCursorPosition(0, 10);
                        }



                    }

                }
                else if (input == 2)
                {
                    if (pmoney >= 1000) // 잔액 확인
                    {
                        pmoney -= 1000;

                        // UI 세팅

                        Console.Clear(); // 화면 지우기
                        Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━┓");
                        Console.WriteLine("┃                     ┃");
                        Console.WriteLine("┃      무기 제작      ┃");
                        Console.WriteLine("┃                     ┃");
                        Console.WriteLine("┃                     ┃");
                        Console.WriteLine("┃                     ┃");
                        Console.WriteLine("┃                     ┃");
                        Console.WriteLine("┃                     ┃");
                        Console.WriteLine("┃                     ┃");
                        Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━┛");

                        // 20회 뽑기 시작
                        for (int i = 1; i <= 20; i++)
                        {
                            rnd = rand.Next(1, 101);
                            Console.SetCursorPosition(2, 5);
                            Console.Write("                    ");
                            Console.SetCursorPosition(2, 6);
                            Console.Write("                    ");

                            Thread.Sleep(200);

                            if (rnd == 1) // 1%
                            {
                                Console.SetCursorPosition(4, 5);
                                Console.WriteLine("다이아 도끼 제작");
                                Console.SetCursorPosition(5, 6);
                                Console.WriteLine("도끼 등급 SSS");
                                SSS++;
                            }
                            else if (rnd >= 2 && rnd <= 6) // 5%
                            {
                                Console.SetCursorPosition(3, 5);
                                Console.WriteLine("플래티넘 도끼 제작");
                                Console.SetCursorPosition(6, 6);
                                Console.WriteLine("도끼 등급 SS");
                                SS++;
                            }
                            else if (rnd >= 7 && rnd <= 17)
                            {
                                Console.SetCursorPosition(6, 5);
                                Console.WriteLine("금 도끼 제작");
                                Console.SetCursorPosition(6, 6);
                                Console.WriteLine("도끼 등급 S");
                                S++;
                            }
                            else if (rnd >= 18 && rnd <= 38)
                            {
                                Console.SetCursorPosition(6, 5);
                                Console.WriteLine("은 도끼 제작");
                                Console.SetCursorPosition(6, 6);
                                Console.WriteLine("도끼 등급 A");
                                A++;
                            }
                            else if (rnd >= 39 && rnd <= 69)
                            {
                                Console.SetCursorPosition(6, 5);
                                Console.WriteLine("철 도끼 제작");
                                Console.SetCursorPosition(6, 6);
                                Console.WriteLine("도끼 등급 B");
                                B++;
                            }
                            else
                            {
                                Console.SetCursorPosition(6, 5);
                                Console.WriteLine("돌 도끼 제작");
                                Console.SetCursorPosition(6, 6);
                                Console.WriteLine("도끼 등급 C");
                                C++;
                            }
                            Thread.Sleep(500); // 0.5초 간격으로 가챠
                        }

                        Console.Clear(); // 화면 지우기
                        Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━┓");
                        Console.WriteLine("┃                     ┃");
                        Console.WriteLine("┃                     ┃");
                        Console.WriteLine("┃                     ┃");
                        Console.WriteLine("┃                     ┃");
                        Console.WriteLine("┃                     ┃");
                        Console.WriteLine("┃                     ┃");
                        Console.WriteLine("┃                     ┃");
                        Console.WriteLine("┃                     ┃");
                        Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━┛");

                        Console.SetCursorPosition(5, 1);
                        Console.WriteLine("가챠 종료");
                        Console.SetCursorPosition(2, 3);
                        Console.Write($"SSS: {SSS}");
                        Console.SetCursorPosition(2, 4);
                        Console.Write($"SS: {SS}");
                        Console.SetCursorPosition(2, 5);
                        Console.Write($"S: {S}");
                        Console.SetCursorPosition(2, 6);
                        Console.Write($"A: {A}");
                        Console.SetCursorPosition(2, 7);
                        Console.Write($"B: {B}");
                        Console.SetCursorPosition(2, 8);
                        Console.Write($"C: {C}");

                        Console.SetCursorPosition(0, 10);
                        Console.Write($"Enter을 눌러 뒤로가기");

                        back = Console.ReadLine();

                    }
                    else
                    {
                        Console.SetCursorPosition(0, 10);
                        Console.WriteLine("돈이 부족합니다. \n");
                        Thread.Sleep(1000);
                    }
                }
                else if (input == 3)
                {
                    Console.Clear(); // 화면 지우기
                    Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━┓");
                    Console.WriteLine("┃                     ┃");
                    Console.WriteLine("┃                     ┃");
                    Console.WriteLine("┃                     ┃");
                    Console.WriteLine("┃                     ┃");
                    Console.WriteLine("┃                     ┃");
                    Console.WriteLine("┃                     ┃");
                    Console.WriteLine("┃                     ┃");
                    Console.WriteLine("┃                     ┃");
                    Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━┛");

                    Console.SetCursorPosition(2, 1);
                    Console.WriteLine($"현재 보유금: {pmoney}");
                    Console.SetCursorPosition(2, 3);
                    Console.Write($"SSS: {SSS}");
                    Console.SetCursorPosition(2, 4);
                    Console.Write($"SS: {SS}");
                    Console.SetCursorPosition(2, 5);
                    Console.Write($"S: {S}");
                    Console.SetCursorPosition(2, 6);
                    Console.Write($"A: {A}");
                    Console.SetCursorPosition(2, 7);
                    Console.Write($"B: {B}");
                    Console.SetCursorPosition(2, 8);
                    Console.Write($"C: {C}");

                    Console.SetCursorPosition(0, 10);
                    Console.Write($"Enter을 눌러 뒤로가기");
                    back = Console.ReadLine();

                }
                else if (input == 4)
                {
                    Console.SetCursorPosition(0, 10);
                    Console.WriteLine("게임을 종료합니다.");
                    Thread.Sleep(1000);
                    Environment.Exit(0);
                }


            }
        }
    }
}
