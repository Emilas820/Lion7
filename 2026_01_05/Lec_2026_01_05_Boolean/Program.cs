using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lec_2026_01_05_Boolean
{
    internal class BooleanTest
    {
        static void Main(string[] args)
        {
            // Lecture 10: bool 형식 - 참 또는 거짓
            bool isRunning = true;
            bool isFinished = false;

            Console.WriteLine(isRunning);
            Console.WriteLine(isFinished);

            // Mission 10: bool 타입을 활용하여 플레이어 상태 출력

            bool isPlaying = true;
            bool isPaused = false;
            bool isHaveKey = false;
            bool isDoorOpen = false;
            bool isPlayerAlive = true;

            int HP = 80; 
            bool isHealthOK = HP >= 50;
            bool isDanger = HP < 50;


            Console.WriteLine("=== 게임 상태 ===");
            Console.WriteLine($"게임 실행 중: {isPlaying}");
            Console.WriteLine($"일시정지: {isPaused}");
            Console.WriteLine($"열쇠 소지: {isHaveKey}");
            Console.WriteLine($"문 열림: {isDoorOpen}");
            Console.WriteLine($"플레이어 생존: {isPlayerAlive}");

            Console.WriteLine("\n=== 캐릭터 상태 ===");
            Console.WriteLine($"체력: {HP}");
            Console.WriteLine($"건강 상태: {isHealthOK}");
            Console.WriteLine($"위험 상태: {isDanger}");

            // 아이템 소지 여부
            bool hasWeapon = true;
            bool hasArmor = false;
            bool hasPotion = true;

            Console.WriteLine("\n=== 인벤토리 ===");
            Console.WriteLine($"무기 보유: {(hasWeapon ? "있음" : "없음")}");
            Console.WriteLine($"방어구 보유: {(hasArmor ? "있음" : "없음")}");
            Console.WriteLine($"포션 보유: {(hasPotion ? "있음" : "없음")}");
            // {(변수명) ? "true인 경우 출력" : "false인 경우 출력"}

        }
    }   
}
