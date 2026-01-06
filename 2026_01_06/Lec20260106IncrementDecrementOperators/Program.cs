using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec20260106IncrementDecrementOperators
{
    internal class IncrementDecrementOperatorsTest
    {
        static void Main(string[] args)
        {
            //Lecture 12: 증감 연산자 ++ --

            int a = 3;
            a++; // 1 증가
            Console.WriteLine(a);

            a--; // 1 감소
            Console.WriteLine(a);

            // * 주의 사항 - 전위, 후위 연산
            int count = 5;

            // 전위 연산
            Console.WriteLine(++count);

            // 후위 연산 - 해당 라인의 컴파일이 끝난 후 연산
            Console.WriteLine(count++);
            Console.WriteLine(count);

            // Mission 12: 전위, 후위를 사용한 콘솔 출력
            
            int KillCount = 0;

            Console.WriteLine("\n=== 몬스터 처치 ===");
            Console.WriteLine($"고블린 처치! (킬 카운트: {++KillCount})");
            Console.WriteLine($"오크 처치! (킬 카운트: {++KillCount})");
            Console.WriteLine($"드래곤 처치! (킬 카운트: {++KillCount})");
            Console.WriteLine($"\n총 처치 수: {KillCount}마리");

            int bullets = 30;
            Console.WriteLine("\n=== 사격 ===");
            Console.WriteLine($"남은 탄약: {bullets}");
            Console.WriteLine($"발사! 남은 탄약: {--bullets}");
            Console.WriteLine($"발사! 남은 탄약: {--bullets}");
            Console.WriteLine($"발사! 남은 탄약: {--bullets}");

            int countdown = 3;
            Console.WriteLine("\n=== 카운트 다운 ===");
            Console.WriteLine(countdown--);
            Console.WriteLine(countdown--);
            Console.WriteLine(countdown--);
            Console.WriteLine("발사!");
        }
    }
}
