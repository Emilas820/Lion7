using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace Lec20260107For
{
    internal class ForTest
    {
        static void Main(string[] args)
        {
            //Lecture 6: for문

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("천마연산신공");
            }


            // 무한 반복
            /*
            for (; ; )
            {
                Console.WriteLine("무량공처");
                Thread.Sleep(3000);
            } */


            // Mission 6_1: 고블린 생성기

            Console.WriteLine("\n=== 몬스터 웨이브 시작 ===");
            int waveMonsterCount = 5;

            for (int i = 1; i <= waveMonsterCount; i++)
            {
                Console.WriteLine((i == waveMonsterCount) ? $"고블린 #{i} 생성! \n총 {i}마리 생성 완료!" : $"고블린 #{i} 생성!");
            }


            // Mission 6_2: 카운트다운

            Console.WriteLine("\n=== 게임 시작 카운트다운 ===");
            int count = 5;
            for (int i = count; i >= 0; i--)
            {
                Console.WriteLine((i <= 0) ? $"게임 시작!" : $"{i}...");
            }


            // Random 객체 생성
            Random random = new Random();

            // 랜덤함수 사용 방법
            int num = random.Next(1, 7); // 1~6까지 임의의 숫자 대입


            // Mission 6_3: 검뽑기
            string sword = "무한의 대검";

            Console.WriteLine("당신은 20번 뽑기가 가능합니다. 지금 실행합니다.🤯, 😭, 😳, 🥵");
            for (int i = 0; i < 20; i++)
            {
                int a = random.Next(1, 101);
                if (0<a && a<=10)
                {
                    sword = "무한의 대검";
                }
                else if (10<a && a <= 30)
                {
                    sword = "카타나";
                }
                else if (30<a && a <= 60)
                {
                    sword = "빛의 봉인검";
                }
                else
                {
                    sword = "정기 점검";
                }
                Console.WriteLine($"{sword}획득!");
                Thread.Sleep(200);
            }

        }

    }
}
