using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20260107Switch
{
    internal class SwitchTest
    {
        static void Main(string[] args)
        {
            // Lecture 4: 반복문 switch

            int day = 3;
            switch (day)
            {
                case 1:
                    Console.WriteLine("월요일");
                    break;
                case 2:
                    Console.WriteLine("화요일");
                    break;
                case 3:
                    Console.WriteLine("수요일");
                    break;
                default:
                    Console.WriteLine("유효하지 않은 요일");
                    break;
            }

            int a = 4;
            switch (a)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("1~3에 해당하는 경우"); //상단을 break 없이 비워두는 경우, 비워둔 조건은 마지막의 출력 조건에 모두 해당된다.
                    break;
                default:
                    Console.WriteLine("유효하지 않은 요일");
                    break;
            }


            // Mission 4_1: 캐릭터 선택 화면 로직

            Console.WriteLine("\n=== 캐릭터 선택 화면 ===");
            Console.Write("직업을 선택하세요: ");
            string input = Console.ReadLine();
            int job = int.Parse(input);

            switch (job)
            {
                case 1:
                    Console.WriteLine("직업: 전사");
                    Console.WriteLine("특성: 강력한 물리 공격력");
                    Console.WriteLine("주 무기: 한손검");
                    Console.WriteLine("스텟: HP +100, 공격력 +20");
                    break;

                case 2:
                    Console.WriteLine("직업: 마법사");
                    Console.WriteLine("특성: 강력한 마법 공격");
                    Console.WriteLine("주 무기: 지팡이, 마법서");
                    Console.WriteLine("스텟: 마나 +100, 마법력 +20");
                    break;
                case 3:
                    Console.WriteLine("직업: 궁수");
                    Console.WriteLine("특성: 긴 사거리와 빠른 공격 속도");
                    Console.WriteLine("주 무기: 활, 쇠뇌");
                    Console.WriteLine("스텟: 사거리 +10, 공격 속도 +20");
                    break;
                case 4:
                    Console.WriteLine("직업: 도적");
                    Console.WriteLine("특성: 빠른 이동 속도와 강력한 일격");
                    Console.WriteLine("주 무기: 단검");
                    Console.WriteLine("스텟: 이동 속도 +10, 크리티컬 확률 +10%");
                    break;
                default:
                    Console.WriteLine("유효하지 않은 선택입니다.");
                    break;
            }


            // Mission 4_2: 아이템 타입별 설명

            Console.WriteLine("\n=== 아이템 정보 ===");
            string itemType = "weapon";

            switch (itemType)
            {
                case "weapon":
                    Console.WriteLine("무기 - 공격력 증가");
                    break;
                case "armor":
                    Console.WriteLine("방어구 - 방어력 증가");
                    break;
                case "potion":
                    Console.WriteLine("물약 - 체력/마나 회복");
                    break;
                case "accessory":
                    Console.WriteLine("장신구 - 특수 능력 부여");
                    break;
                default:
                    Console.WriteLine("알 수 없는 아이템");
                    break;
            }

            // Mission 4_3: 요일별 이벤트

            Console.WriteLine("\n=== 오늘의 이벤트 ===");
            int dayOfWeek = 3;  // 0:일, 1:월, 2:화, 3:수, 4:목, 5:금, 6:토

            switch (dayOfWeek)
            {
                case 0:
                    Console.WriteLine("일요일: 경험치 2배");
                    break;
                case 1:
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("평일: 일반 보상"); // 월~목까지 해당
                    break;
                case 5:
                    Console.WriteLine("금요일: 골드 2배");
                    break;
                case 6:
                    Console.WriteLine("토요일: 아이템 드롭률 2배");
                    break;
                default:
                    Console.WriteLine("잘못된 요일");
                    break;

            }
        }
    }
}
