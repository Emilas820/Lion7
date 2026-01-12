using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20260112
{
    internal class Function_1
    {
        // 매개변수가 있는 함수
        // int 넘겨보기
        static void Attack(int atk, int def)
        {
            Console.WriteLine("공격력: "+atk);
            Console.WriteLine("방어력: "+def);
        }

        // Player 정보 넘겨보기

        static void PlayerStatus(string name, int atk, int def, int dex, int luk)
        {
            Console.WriteLine($"플레이어 이름: {name}");
            Console.WriteLine($"공격력 : {atk}");
            Console.WriteLine($"방어력 : {def}");
            Console.WriteLine($"민첩성 이름: {dex}");
            Console.WriteLine($"행운: {luk}");
        }

        static void Main(string[] args)
        {
            Attack(100, 20);
            Console.WriteLine();
            PlayerStatus("김철수", 10, 10, 10, 5);
        }
    }
}
