using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec20260106Mission
{
    internal class Mission20260106
    {
        static void Main(string[] args)
        {
            // Mission 1

            const int MAXHP = 100;
            int CurrentHP = 80;
            int MonsterDMG = 25;
            int HPPosion = 30;
            int PoisonDMG = 5;


            Console.WriteLine("=== 문제 1 ===");
            Console.WriteLine($"초기 체력: {CurrentHP}/{MAXHP}");
            CurrentHP -= MonsterDMG;
            Console.WriteLine($"데미지 -{MonsterDMG}: {CurrentHP}/{MAXHP}");
            CurrentHP += HPPosion;
            Console.WriteLine($"회복 +{HPPosion}: {CurrentHP}/{MAXHP}");
            CurrentHP -= PoisonDMG;
            Console.WriteLine($"독 데미지 -{PoisonDMG}: {CurrentHP}/{MAXHP}");

            // Mission 2

            int expPerMonster = 150;
            int killedMonsters = 3;
            int expForLevelUp = 500;

            Console.WriteLine("\n=== 문제 2 ===");
            Console.WriteLine($"처치한 몬스터: {killedMonsters}마리");
            Console.WriteLine($"획득 경험치: {expPerMonster* killedMonsters}");
            Console.WriteLine($"레벨업까지 필요: {expForLevelUp - expPerMonster * killedMonsters}");

            // Mission 3

            int totalGold = 1234;
            int partyMembers = 5;

            Console.WriteLine("\n=== 문제 3 ===");
            Console.WriteLine($"총 골드: {totalGold}");
            Console.WriteLine($"파티원: {partyMembers}명");
            Console.WriteLine($"1인당 골드: {totalGold/partyMembers}");
            Console.WriteLine($"남은 골드: {totalGold%partyMembers}");

            // Mission 4

            int playerLevel = 35;
            int requiredLevel = 30;
            bool hasKey = true;
            int currentHP = 60;
            int requiredHP = 50;
            int maxHP = 100;

            Console.WriteLine("\n=== 문제 4 ===");
            Console.WriteLine("\n=== 던전 입장 조건 ===");
            Console.WriteLine($"레벨 조건 ({requiredLevel} 이상): {playerLevel >= requiredLevel}");
            Console.WriteLine($"열쇠 보유: {hasKey}");
            Console.WriteLine($"체력 조건 ({requiredHP}% 이상): {currentHP >= requiredHP}");
            Console.WriteLine($"입장 가능: {playerLevel >= requiredLevel && currentHP >= requiredHP}");

            // Mission 5

            float originalPrice = 5000f;
            float DCpercentage = 20f;
            float coupon = 500f;
            bool isVIP = true;
            bool hasCoupon = true;

            Console.WriteLine("\n=== 문제 5 ===");
            Console.WriteLine($"원가: {originalPrice}");
            Console.WriteLine($"VIP 할인 ({DCpercentage}%): {originalPrice*((100-DCpercentage)/100)}");
            Console.WriteLine($"쿠폰 할인 (-{coupon}): {originalPrice * ((100 - DCpercentage) / 100)- coupon}");
            Console.WriteLine($"최종 가격: {originalPrice * ((100 - DCpercentage) / 100) - coupon}");


        }
    }
}
