using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20260114_2
{
    class Character2
    {
        // public, private . . .
        // protected - 상속이 되어있는 자식이 사용 가능하게 열어주는 접근 제어자
        protected string name;
        protected int level;
        protected int hp;
        protected int maxHP;
        protected int atk;
        protected int def;

        public Character2(string name)
        {
            this.name = name;
            level = 1;
            maxHP = 100;
            hp = maxHP;
            atk = 30;
            def = 20;

            Console.WriteLine($"{name} 생성!\n");
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"이름: {name}");
            Console.WriteLine($"레벨: {level}");
            Console.WriteLine($"HP: {hp} / {maxHP}");
            Console.WriteLine($"공격력: {atk}");
            Console.WriteLine($"방어력: {def}");
        }
    }

    // 자식 클래스: 전사

    class Warrior2 : Character2
    {
        private int rage; // 전사만의 고유 속성

        public Warrior2(string name):base(name)
        {
            //name = "전사";
            level = 1;
            atk = 60;
            def = 40;
            maxHP = 150;
            hp = maxHP;
            rage = 10;

            Console.WriteLine("직업: 전사\n");
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"분노: {rage}");
        }
    }

    internal class Base
    {
        static void Main(string[] args)
        {
            // 부모 객체 생성
            Character2 character = new Character2("김철수");

            character.ShowInfo();
            Console.WriteLine();

            // 자식 객체 생성: 부모 객체 생성 -> 부모 객체 생성자 실행 -> 자식 객체 생성 -> 자식 생성자 실행(덮어쓰기)
            Warrior2 warrior = new Warrior2("홍길동");

            warrior.ShowInfo();

            // Tip -> 소멸자 순서는 자 -> 부 순서이다.


            // 메서드 오버라이드
            // 부모 객체로 생성 시 부모, 자식 선별적으로 호출 가능.

            Character2 character2 = new Warrior2("마존");
            character2.ShowInfo();            

        }
    }
}
