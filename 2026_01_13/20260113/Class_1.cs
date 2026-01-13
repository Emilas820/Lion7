using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20260113
{
    class 클래스이름
    {
        // 필드 - (변수 데이터)
        // 프로퍼티 - (속성)
        // 메서드 - (기능)
    }

    class Character
    {
        // public은 다른 곳에서 사용 가능하다.
        // private는 클래스 내부에서만 사용할 수 있다.

        public string name;     
        public int level;
        public int hp;
        public int mp;
        private int maxHp;
        private int maxMp;

        // 기본 생성자 - 초기화 담당 (Defalt Data)
        public Character()
        {
            name = "용사님";
            level = 1;
            hp = 100;
            mp = 100;
        }

        // 인자 있는 생성자
        public Character(int _maxHp, int _maxMp)
        {
            maxHp = _maxHp;
            maxMp = _maxMp;
        }

        public void ShowStatus()
        {
            Console.WriteLine($"이름: {name}");
            Console.WriteLine($"레벨: {level}");
            Console.WriteLine($"hp: {hp}");
            Console.WriteLine($"최대 hp: {maxHp}");
            Console.WriteLine($"mp: {mp}");
            Console.WriteLine($"최대mp: {maxMp}");
        }

    }

    internal class Class_1
    {
        static void Main(string[] args)
        {
            // 객체 생성
            Character player1 = new Character(); // 메모리 지정, 생성자 호출

            player1.name = "홍길동";
            player1.level = 1;
            player1.hp = 100;
            player1.mp = 80;

            Console.WriteLine($"이름: {player1.name}");
            Console.WriteLine($"레벨: {player1.level}");
            Console.WriteLine($"hp: {player1.hp}");
            // Console.WriteLine($"최대 hp: {player1.maxHp}"); - private 사용 불가
            Console.WriteLine($"mp: {player1.mp}");
            // Console.WriteLine($"최대mp: {player1.maxMp}"); - private 사용 불가

            Console.WriteLine();

            player1.ShowStatus(); // 클래스 내 함수 사용, 함수를 통한 private 출력 가능

            Console.WriteLine();


            Character player2 = new Character(100, 100); // 새로운 객체 생성, 인자가 있는 생성자 받음, private 값 입력 가능

            player2.name = "김철수";
            player2.level = 3;
            player2.hp = 10;
            player2.mp = 20;

            player2.ShowStatus(); // 함수를 통한 private 출력 가능

        }
    }
}
