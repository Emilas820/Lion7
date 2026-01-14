using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20260114
{
    // 클래스끼리 통신
    class Player_
    {
        private int hp;
        private int atk;

        public void SetHp(int hp)
        {
            this.hp = hp;
        }

        public void SetAtk(int atk)
        {
            this.atk = atk;
        }
        public int GetHp() { return hp; }

        public int GetAtk() { return atk; }


        public void Render()
        {
            Console.WriteLine("\n플레이어");
            Console.WriteLine("체력: " + hp);
            Console.WriteLine("공격력: " + atk);
        }

    }

    class Monster
    {
        private int hp;
        private int atk;
        public void SetHp(int hp)
        {
            this.hp = hp;
        }

        public void SetAtk(int atk)
        {
            this.atk = atk;
        }
        public int GetHp() { return hp; }

        public int GetAtk() { return atk; }
        public void Render()
        {
            Console.WriteLine("\n몬스터");
            Console.WriteLine("체력: " + hp);
            Console.WriteLine("공격력: " + atk);
        }

    }


    internal class Class_1
    {
        static void Main(string[] args)
        {
            // 플레이어 객체 생성
            Player_ player = new Player_();
            player.SetAtk(10);
            player.SetHp(100);

            // 몬스터 객체 생성
            Monster monster = new Monster();
            monster.SetAtk(10);
            monster.SetHp(100);

            // 공격
            monster.SetHp(monster.GetHp() - player.GetAtk());   // 플레이어 -> 몬스터
            player.SetHp(player.GetHp() - monster.GetAtk());    // 몬스터 -> 플레이어

            player.Render();
            monster.Render();

        }
    }
}
