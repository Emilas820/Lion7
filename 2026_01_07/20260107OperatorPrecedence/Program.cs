using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20260107OperatorPrecedence
{
    internal class OperatorPrecedenceTest
    {
        static void Main(string[] args)
        {
            // Lecture 2: 연산자 우선순위

            int result = 10 + 2 * 5;
            Console.WriteLine(result);

            int adjustedResult = (10 + 2) * 5;  // 괄호로 우선순위 변경
            Console.WriteLine(adjustedResult);


            // Mission 2: 데미지 계산
            int baseDamage = 50;
            int bonusDamage = 20;
            double criticalMultiplier = 1.5;

            // 잘못된 계산
            double damage1 = baseDamage + bonusDamage * criticalMultiplier;
            // 올바른 계산
            double damage2 = (baseDamage + bonusDamage) * criticalMultiplier;

            Console.WriteLine("\n=== 크리티컬 데미지 계산 ===");
            Console.WriteLine($"기본 데미지: {baseDamage}");
            Console.WriteLine($"보너스 데미지: {bonusDamage}");
            Console.WriteLine($"크리티컬 배율: {criticalMultiplier}");
            Console.WriteLine($"잘못된 계산: {damage1}");  // 80.0
            Console.WriteLine($"올바른 계산: {damage2}");  // 105.0


        }
    }
}
