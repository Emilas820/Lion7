using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20260113
{
    class Player
    {
        private string name;
        private int gold;
        private int maxHP;

        public string Name { get { return name;  } set { name = value; } }
        public int Gold
        {
            get { return gold; }
            set { if (value < 0)
                {
                    Console.WriteLine("골드가 부족합니다.");
                }
                else
                {
                    gold = value;
                }
            }
        }
    }
    internal class Property_2
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.Name = "홍길동";
            player.Gold = -1000;
            // player.maxHP = 100; // ->읽기 전용이라 수정 불가

            Console.WriteLine($"이름: {player.Name}");
            Console.WriteLine($"골드: {player.Gold}");
        }
    }
}
