using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_Const_2025_01_05
{
    internal class ConstTest
    {
        static void Main(string[] args)
        {
            // Lecture 1: 상수 사용하기.

            // 상수: 값을 변경할 수 없는 변수.
            const double Pi = 3.14159; //상수 Pi선언 및 초기화
            const int MacxScore = 100; //정수형 상수 선언

            // 출력
            Console.WriteLine("Pi: " + Pi); // 출력: Pi: 3.14159
            Console.WriteLine("Max Score: " + MacxScore); // 출력: Max Score: 100

            // Pi = 3.14; // 오류: 상수는 값을 변경할 수 없음

            // Mission 1: 상수를 통해 화면 구성
            // Tip: 상수는 대문자로 작성하는 것이 관례.
            const int MAX_PLAYER = 4; //최대 플레이어 수 상수
            const int GOLD = 1000; //시작 골드 상수
            const string CURRENT_VERSION = "1.0.0"; //게임 버전 상수

            Console.WriteLine("**실행 결과: **");
            Console.WriteLine("' ' '");
            Console.WriteLine("=== 게임 설정 ===");
            Console.WriteLine("최대 플레이어: " + MAX_PLAYER + "명");
            Console.WriteLine("시작 골드:" + GOLD + "G");
            Console.WriteLine("버전: " + CURRENT_VERSION);

        }
    }
}
