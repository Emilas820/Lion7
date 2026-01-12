using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace _20260112
{
    internal class Function_6
    {
        // 실습
        static void useItem(string usedItem, int healPoint)
        {
            Console.WriteLine($"\n{usedItem} 사용 !");
            Console.WriteLine($"회복량: {healPoint}HP");
        }

        static void spawnspell(string spawnTarget, int level, int count)
        {
            Console.WriteLine($"\n{spawnTarget} 소환");
            Console.WriteLine($"레벨: {level}");
            Console.WriteLine($"수량: {count}");
        }

        static void Main(string[] args)
        {
            useItem("회복 포션", 50);
            useItem("고급 회복 포션", 100);
            spawnspell("슬라임", 1, 1);
            spawnspell("고블린", 5, 1);
            spawnspell("드래곤", 50, 3);
        }
    }
}
