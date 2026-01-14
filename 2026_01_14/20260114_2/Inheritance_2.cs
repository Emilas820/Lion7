using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20260114_2
{

    class Character
    {
        // public, private . . .
        // protected - 상속이 되어있는 자식이 사용 가능하게 열어주는 접근 제어자
        protected string name;
        protected int level;
        protected int hp;
        protected int maxHP;
        protected int atk;
        protected int def;

        public Character()
        {
            name = "기본 캐릭터";
            level = 1;
            maxHP = 100;
            hp = maxHP;
            atk = 30;
            def = 20;

            Console.WriteLine($"{name} 생성!\n");
        }

        public void Showinfo()
        {
            Console.WriteLine($"이름: {name}");
            Console.WriteLine($"레벨: {level}");
            Console.WriteLine($"HP: {hp} / {maxHP}");
            Console.WriteLine($"공격력: {atk}");
            Console.WriteLine($"방어력: {def}");

        }
    }

    // 자식 클래스: 전사

    class Warrior : Character
    {
        private int rage; // 전사만의 고유 속성

        public Warrior()
        {
            name = "전사";
            level= 1;
            atk = 60;
            def = 40;
            maxHP = 150;
            hp = maxHP;
            rage = 10;

            Console.WriteLine("직업: 전사\n");
        }

        public void ShowInfo2()
        {
            base.Showinfo();
            Console.WriteLine($"분노: {rage}");
        }
    }


    internal class Inheritance_2
    {
        static void Main(string[] args)
        {
            // 부모 객체 생성
            Character character = new Character();

            character.Showinfo();
            Console.WriteLine();

            // 자식 객체 생성: 부모 객체 생성 -> 부모 객체 생성자 실행 -> 자식 객체 생성 -> 자식 생성자 실행(덮어쓰기)
            Warrior warrior = new Warrior();

            warrior.ShowInfo2();

            // Tip -> 소멸자 순서는 자 -> 부 순서이다.
        }
    }
}
