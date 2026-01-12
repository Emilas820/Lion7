using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20260112
{
    internal class Function_4
    {
        // 오버로딩
        static void Attack()
        {
            Console.WriteLine("기본공격");
            Console.WriteLine("데미지: 50");
        }

        // 이름이 같더라도 인자값이 다르면 다른 함수 취급
        static void Attack(string target)
        {
            Console.WriteLine($"{target} 공격!");
            Console.WriteLine("데미지: 50");
        }

        static void Attack(string target, int a)
        {
            Console.WriteLine($"{target} 공격!");
            Console.WriteLine($"데미지: {a}");
        }

        static void Attack(string skillName, string targetName, int damage)
        {
            Console.WriteLine($"스킬 발동: {skillName}");
            Console.WriteLine($"{targetName}에게 {damage} 데미지!");
        }

        static void Main(string[] args)
        {
            Attack();
            Console.WriteLine();

            Attack("플레이어");
            Console.WriteLine();

            Attack("고블린", 50);
            Console.WriteLine();

            Attack("파이어볼", "고블린", 50);

        }
    }
}
