using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20260107SequentialStatement
{
    internal class SequentialStatementTest
    {
        static void Main(string[] args)
        {/*
            // Lecture 3: if문

            int score = 85;
            if (score >= 90)
            {
                Console.WriteLine("A학점");
            }
            else
            {
                Console.WriteLine("B학점");
            }

            // else 설명 - if의 조건이 거짓일 때 실행

            int num = 10;
            if (num > 15)
            {
                Console.WriteLine("15보다 큽니다.");
            }
            else
            {
                Console.WriteLine("15보다 작거나 같습니다.");
            }

            // if else 설명 - 다중 조건 처리

            if (score >= 90)
            {
                Console.WriteLine("A학점");
            }
            else if (score >= 80)
            {
                Console.WriteLine("B학점");
            }
            else if (score >= 70)
            {
                Console.WriteLine("C학점");
            }
            else
            {
                Console.WriteLine("F학점");
            }

            // if문은 한 줄일 경우 중괄호를 생략 가능하다. 괄호 없이 다음 내용을 적을 경우, if문 바깥의 요소로 해석.

            int a = 10;
            if (a == 10)
                Console.WriteLine("출력");

            Console.WriteLine("if문 바깥");

            if (a == 20)
            {
                Console.WriteLine("출력");
            }
            Console.WriteLine("if문 바깥");

            // 조건에 연산자를 다양하게 넣을 수 있다.

            int x = 70;
            if (x >= 90)
            {
                Console.WriteLine("A등급");
            }
            else if (x > 80 && x <= 89)
            {
                Console.WriteLine("B등급");
            }
            else if (x > 70 && x <= 79)
            {
                Console.WriteLine("C등급");
            }
            else
            {
                Console.WriteLine("D등급");
            }
            */

            // Mission 3_1:　HP체크 로직

            int hp = 30;
            int maxHP = 100;

            int enemyDistance = 5;
            int attackRange = 3;

            Console.WriteLine("\n** 실행 결과 **");
            Console.WriteLine($"현재 체력: {hp}/{maxHP}");

            if (hp > maxHP * 0.5)
            {
                Console.WriteLine("\n");
            }
            else if (hp <= maxHP * 0.5 && hp > maxHP * 0.3)
            {
                Console.WriteLine("체력이 50% 이하입니다.");
            }
            else if (hp <= maxHP * 0.3 && hp > maxHP * 0)
            {
                Console.WriteLine("경고: 체력이 위험합니다!");
                Console.WriteLine("회복 아이템을 사용하세요!");
            }
            else
            {
                Console.WriteLine("게임 오버!");
                Console.WriteLine("부활 지점에서 다시 시작합니다.");
            }
            if (enemyDistance <= attackRange)
            {
                Console.WriteLine("적이 사거리 안에 있습니다!");
                Console.WriteLine("공격 가능!");
            }

            // Mission 3_2: 아이템 구매 시스템

            int playerGold = 500;
            int itemPrice = 250;
            string itemName = "강철 검";

            Console.WriteLine("\n=== 상점 ===");
            Console.WriteLine($"아이템: {itemName}");
            Console.WriteLine($"가격: {itemPrice}G");
            Console.WriteLine($"소지금: {playerGold}G\n");

            if (playerGold >= itemPrice)
            {
                playerGold -= itemPrice;
                Console.WriteLine("구매 성공!");
                Console.WriteLine($"{itemName}를 획득했습니다.");
                Console.WriteLine($"남은 골드: {playerGold}G");
            }
            else
            {
                int needGold = itemPrice - playerGold;
                Console.WriteLine("골드가 부족합니다!");
                Console.WriteLine($"필요한 골드: {needGold}G");
            }

            Console.WriteLine("\n=== 던전 입장 ===");
            int playerLevel = 48;
            int requiredLevel = 50;

            if (playerLevel >= requiredLevel)
            {
                Console.WriteLine("던전에 입장합니다!");
                Console.WriteLine("전투 준비!");
            }
            else
            {
                Console.WriteLine("레벨이 부족합니다!");
                Console.WriteLine($"필요 레벨: {requiredLevel}");
                Console.WriteLine($"현재 레벨: {playerLevel}");
                Console.WriteLine($"레벨업이 필요합니다. (Lv.{requiredLevel - playerLevel} 필요)");
            }

            // Mission 3_3: 점수에 따른 등급 판정

            string scoreInput;
            string rank;

            Console.WriteLine("\n=== 게임 랭크 시스템 ===");
            Console.Write($"당신의 점수를 입력하세요: ");
            scoreInput = Console.ReadLine();
            int playerScore = int.Parse(scoreInput);

            if(playerScore >= 10000)
            {
                rank = "SSS";
                Console.WriteLine($"등급: {rank} (레전드)");
                Console.WriteLine("보상: 전설 아이템 + 골드 10,000G");
            }
            else if (playerScore >= 8000)
            {
                rank = "SS";
                Console.WriteLine($"등급: {rank} (마스터)");
                Console.WriteLine("보상: 영웅 아이템 + 골드 5,000G");
            }
            else if (playerScore >= 6000)
            {
                rank = "S";
                Console.WriteLine($"등급: {rank} (다이아)");
                Console.WriteLine("보상: 희귀 아이템 + 골드 3,000G");
            }
            else if (playerScore >= 6000)
            {
                rank = "S";
                Console.WriteLine($"등급: {rank} (다이아)");
                Console.WriteLine("보상: 전설 아이템 + 골드 3,000G");
            }
            else if (playerScore >= 4000)
            {
                rank = "A";
                Console.WriteLine($"등급: {rank} (플래티넘)");
                Console.WriteLine("보상: 고급 아이템 + 골드 1,500G");
            }
            else
            {
                rank = "B";
                Console.WriteLine($"등급: {rank} (골드)");
                Console.WriteLine("보상: 일반 아이템 + 골드 500G");
            } 

            // Mission 3_4: 캐릭터 상태 판정

            Console.WriteLine("\n=== 캐릭터 상태 ===");
            Console.Write("당신의 HP를 입력하세요:");

            string healthInput = Console.ReadLine();
            int health = int.Parse(healthInput);

            
            if (health >= 80)
            {
                Console.WriteLine("♥ 상태: 매우 좋음");
            }
            else if(health >= 60)
            {
                Console.WriteLine("● 상태: 좋음");
            }
            else if (health >= 40)
            {
                Console.WriteLine("○ 상태: 보통");
            }
            else if (health >= 20)
            {
                Console.WriteLine("@ 상태: 위험");
            }
            else
            {
                Console.WriteLine("X 상태: 매우 위험!");
            }
        }
    }
}
