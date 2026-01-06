using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec20260106AllocationOperator
{
    internal class AllocationOperatorTest
    {
        static void Main(string[] args)
        {
            //ㅣLecture 11: 할당 연산자

            int a = 5;
            a = a +5;
            Console.WriteLine(a);   // 출력: 10


            int b = 5;
            b += 5;
            Console.WriteLine(b);   // 출력: 10

            Console.WriteLine("=== 기본 산술 연산자 ===");

            //a, b 초기화
            a = 5;
            b = 5;

            a = a + b;
            Console.WriteLine("합계: " + a);

            a = 5;
            a = a - b;
            Console.WriteLine("합계: " + a);

            a = 5;
            a = a * b;
            Console.WriteLine("합계: " + a);

            a = 5;
            a = a / b;
            Console.WriteLine("합계: " + a);

            a = 5;
            a = a % b;
            Console.WriteLine("합계: " + a);


            Console.WriteLine("\n=== 할당 연산자 ===");


            a = 5;
            a += b;
            Console.WriteLine("합계: " + a);

            a = 5;
            a -= b;
            Console.WriteLine("합계: " + a);

            a = 5;
            a *= b;
            Console.WriteLine("합계: " + a);

            a = 5;
            a /= b;
            Console.WriteLine("합계: " + a);

            a = 5;
            a %= b;
            Console.WriteLine("합계: " + a);

            // Mission 11_1: 캐릭터 스텟 계산

            int baseAttack = 50;
            int weaponDamage = 30;
            int totalAttack = baseAttack + weaponDamage;

            Console.WriteLine("\n=== 공격력 계산 ===");
            Console.WriteLine($"기본 공격력: {baseAttack}");
            Console.WriteLine($"무기 데미지: {weaponDamage}");
            Console.WriteLine($"총 공격력: {totalAttack}");

            // Mission 11_2: 데미지 계산

            int playerHP = 100;
            int damage = 25;
            playerHP -= damage;

            Console.WriteLine("\n=== 데미지 계산 ===");
            Console.WriteLine($"받은 데미지: {damage}");
            Console.WriteLine($"남은 체력: {playerHP}");

            // Mission 11_3: 경험치 계산

            int Killedmonsters = 5;
            int expPerMonster = 100;
            int totalExp = Killedmonsters * expPerMonster;

            Console.WriteLine("\n=== 경험치 획득 ===");
            Console.WriteLine($"처치한 몬스터: {Killedmonsters}마리");
            Console.WriteLine($"몬스터당 경험치: {expPerMonster}");
            Console.WriteLine($"총 경험치: {totalExp}");

            // Mission 11_4: 골드 분배

            int totalGold = 1000;
            int playerCount = 4;
            int goldPerPlayer = totalGold / playerCount;
            int remainingGold = totalGold % playerCount;

            Console.WriteLine("\n=== 골드 분배 ===");
            Console.WriteLine($"총 골드: {totalGold}G");
            Console.WriteLine($"플레이어 수: {playerCount}명");
            Console.WriteLine($"1인당 골드: {goldPerPlayer}G");
            Console.WriteLine($"남은 골드: {remainingGold}G");
        }
    }
}
