using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _20260113
{

    class Monster
    {
        public string name;
        public int level;
        public int hp;
        public int atk;
        public int def;
        public int expReward;

        public Monster()
        {
            name = "슬라임";
            level = 1;
            hp = 10;
            atk = 10;
            def = 5;
            expReward = 10;
        }

        public Monster(string monsterName, int monsterLevel)
        {
            name = monsterName;
            level = monsterLevel;
            hp = 50 * level;
            atk = 10 * level;
            def = 5 * level;
            expReward = 10 * level;
        }

        public void ShowStats()
        {
            Console.WriteLine($"몬스터 {name} (Lv.{level}) 등장 !");
            Console.WriteLine($"    HP: {hp}");
            Console.WriteLine($"    공격력: {atk}");
            Console.WriteLine($"    방어력:  {def}");
            Console.WriteLine($"    경험치: {expReward}");

        }
    }

    internal class Class_3
    {
        static void Main(string[] args)
        {
            // 기본 생성자를 사용하여 객체 생성
            Monster Slim = new Monster();
            Slim.ShowStats();

            // 인자 있는 생성자 사용, 고블린 생성
            Monster Goblin = new Monster("고블린", 5);
            Goblin.ShowStats();

            Console.WriteLine("\n=== 필드 몬스터 ===");
            Monster[] monsters = new Monster[3];
            monsters[0] = new Monster("늑대", 3);
            monsters[1] = new Monster("오크", 7);
            monsters[2] = new Monster("트롤", 10);

            for(int i =0;i<monsters.Length;i++)
            {
                monsters[i].ShowStats();
                Console.WriteLine();
            }
        }
    }
}
