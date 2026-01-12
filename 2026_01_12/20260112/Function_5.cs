using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20260112
{
    internal class Function_5
    {
        // 기본 매개변수 사용

        static void CastFireBall(string target, int damage = 100, int manaCost = 30)
        {
            // 매개변수가 입력되지 않는 경우, 상단에 적혀있는 값으로 초기화.
            Console.WriteLine($" 파이어볼 시전 ! ");
            Console.WriteLine($" 대상: {target} ");
            Console.WriteLine($" 데미지: {damage}");
            Console.WriteLine($" 마나 소모: {manaCost}");
        }
        static void Main(string[] args)
        {
            // 모든 매개변수 지정
            CastFireBall("고블린", 150, 40);
            Console.WriteLine();

            // 두 개만 지정
            CastFireBall("고블린", 20);
            Console.WriteLine();

            // 필수만 지정
            CastFireBall("드래곤");
            Console.WriteLine();

            // 중간값 생략
            CastFireBall("고블린", manaCost: 50);
            Console.WriteLine();

        }
    }
}
