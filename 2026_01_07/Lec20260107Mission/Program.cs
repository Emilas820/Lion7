using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec20260107Mission
{
    internal class Mission20260107
    {
        static void Main(string[] args)
        {
            // Mission 1

            Console.WriteLine("=== 예제 1 ===");
            Console.Write("오늘의 온도를 입력해 주세요: ");
            string input1 = Console.ReadLine();
            int c = int.Parse(input1);

            Console.WriteLine($"현재 온도: {c}℃");

            if(c >= 30)
            {
                Console.WriteLine("매우 더워요! 반팔과 반바지를 입으세요!");
            }
            else if (c >= 20 && c < 30)
            {
                Console.WriteLine("🤯적당해요! 긴팔 티셔츠를 입으세요!");
            }
            else if(c >= 10 && c<20)
            {
                Console.WriteLine("쌀쌀해요! 가디건이나 자켓을 챙기세요!");
            }
            else
            {
                Console.WriteLine("매우 추워요! 패딩고 목도리가 필요해요!");
            }

            // Mission 2

            Console.WriteLine("=== 예제 2 ===");
            Console.WriteLine("\n=== 캐릭터 생성 ===");
            Console.WriteLine("직업 선택 (1: 전사, 2: 마법사, 3: 궁수, 4: 도적)");

            string input2 = Console.ReadLine();
            int job = int.Parse(input2);

            switch (job)
            {
                case 1:
                    Console.WriteLine("전사 - 높은 체력과 방어력");
                    Console.WriteLine("시작 스텟: HP +50, 공격력 +10");
                    break;
                case 2:
                    Console.WriteLine("마법사 - 강력한 마법 공격");
                    Console.WriteLine("시작 스텟: 마나 +100, 마법력 +20");
                    break;
                case 3:
                    Console.WriteLine("궁수 - 우너거리 공격 특화");
                    Console.WriteLine("시작 스텟: 민첩 +15, 크리티컬 +10%");
                    break;
                case 4:
                    Console.WriteLine("도적 - 빠른 속도와 회피");
                    Console.WriteLine("시작 스텟: 민첩 +20%, 회피율 15%");
                    break;
                default:
                    Console.WriteLine("잘못된 선택입니다. ~4 중에서 선택해 주세요.");
                    
                    break;
            }
        }
    }
}
