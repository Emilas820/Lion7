using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec20260108While
{
    internal class WhileTest
    {
        static void Main(string[] args)
        {
            // Lecture 1: While문
            
            int i = 0;

            while (i < 10) // i = 10까지 루프
            {
                i++;
                Console.WriteLine($"{i}");
            }


            // Mission 1_1: 카운트다운

            Console.WriteLine("\n=== 카운트 다운 ===");

            int countdown = 10;
            while (countdown > 0) // 10부터 1까지 카운트다운
            {
                Console.WriteLine($"{countdown}");
                countdown--;
            }


            // Mission 1_2: 합계 구하기

            Console.WriteLine("\n=== 합계 구하기 ===");
            int sum = 0;
            int a = 1;

            while (a <= 5)
            {
                sum += a;
                a++;
                Console.WriteLine($"{sum}");
            }


            // Mission 1_3: 특정 값까지 반복

            Console.WriteLine("\n=== 목표 달성학 ===");
            int coin = 0;
            int target = 50;
            int day = 0;

            while (coin < target)
            {
                day++;
                coin += 10;
                Console.WriteLine($"{day}일차: 코인 {coin}개");
                
            }


            // * do While문 - 무조건 한 번은 실행된 후 조건을 본다.

            int x = 5;
            do
            {
                Console.WriteLine("최소 한 번 실행됩니다.");
                x--;

            } while (x > 0);

            
            // Mission 1_4: 메뉴판

            
            int totalPrice = 0;
            string choice;

            do
            {
                Console.WriteLine("\n=== 메뉴판 ===");
                Console.WriteLine("1. 짜장면 - 5,000원");
                Console.WriteLine("2. 짬뽕 - 6,000원");
                Console.WriteLine("3. 탕수육 - 15,000원");
                Console.WriteLine("4. 볶음밥 - 7,000원");
                Console.WriteLine("0. 주문 완료");
                Console.WriteLine("==============");

                choice = Console.ReadLine();

                // 메뉴 선택 처리
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("짜장면 추가! (+5,000원)");
                        totalPrice += 5000;
                        break;
                    case "2":
                        Console.WriteLine("짬뽕 추가! (+4,000원)");
                        totalPrice += 6000;
                        break;
                    case "3":
                        Console.WriteLine("탕수육 추가! (+15,000원)");
                        totalPrice += 15000;
                        break;
                    case "4":
                        Console.WriteLine("볶음밥 추가! (+7,000원)");
                        totalPrice += 7000;
                        break;
                    case "0":
                        Console.WriteLine("주문을 완료합니다.");
                        Console.WriteLine($"총액: {totalPrice:N0}원");
                        
                        break;
                    default:
                        Console.WriteLine("잘못된 선택입니다.");
                        break;
                }
                // 0 선택 전까지
                if(choice != "0")
                {
                    Console.WriteLine($"현재 총액: {totalPrice:N0}원");
                }
                
            } while (choice != "0");
        }
    }
}
