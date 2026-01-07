using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec20260107etcOperators
{
    internal class TernaryOperatorsTest
    {
        static void Main(string[] args)
        {
            // Lecture 1: 기타 연산자 - 삼항 연산자

            int a = 10, b = 20;
            int max = (a > b) ? a : b;
            Console.WriteLine(max);

            // 문자열 출력도 가능

            int score = 85;
            string result = (score >= 60) ? "합격" : "불합격";

            Console.WriteLine("=== 시험 결과 ===");
            Console.WriteLine($"점수: {score}");
            Console.WriteLine($"결과: {result}");

            // Mission 1_1: 레벨에 따른 등급

            int playerLevel = 45;
            
            string Rank = (playerLevel >= 50) ? "고급" :
                          (playerLevel >= 30) ? "중급" : "초급";

            Console.WriteLine("\n=== 예제 1 ===");
            Console.WriteLine("플레이어 등급");
            Console.WriteLine($"레벨: {playerLevel}");
            Console.WriteLine($"등급: {Rank}");

            // Mission 1_2: 
            int hp = 30;
            int maxHP = 100;
            string playerStatus = (hp >= maxHP * 0.7) ? "안전" :
                                  (hp >= maxHP * 0.3) ? "주의" : "위험";

            Console.WriteLine("\n=== 예제 2 ===");
            Console.WriteLine($"현재 체력: {hp}/{maxHP}");
            Console.WriteLine($"상태: {playerStatus}");
        }
    }
}
