using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20260113
{

    // 캐릭터 클래스 정의
    
    class Character1
    {
        // 필드 (변수)
        private string name;
        private int level;
        private int hp;
        private int maxHP;
        private int mp;
        private int maxMP;

        public Character1(string _name, int _level, int _hp, int _maxHP, int _mp, int _maxMP)
        {
            name = _name;
            level = _level; 
            hp = _hp;
            maxHP = _maxHP;
            mp = _mp;
            maxMP = _maxMP;
        }

        public Character1 ()
        {

        }

        // 메서드 (함수)
        public void ShowInfo()
        {
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━");
            Console.WriteLine($"이름: {name}");
            Console.WriteLine($"레벨: {level}");
            Console.WriteLine($"HP: {hp} / {maxHP}");
            Console.WriteLine($"MP: {mp} / {maxMP}");
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━");
        }
        public void ShowInfo2(string _name, int _level, int _hp, int _maxHP, int _mp, int _maxMP)
        {
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━");
            Console.WriteLine($"이름: {_name}");
            Console.WriteLine($"레벨: {_level}");
            Console.WriteLine($"HP: {_hp} / {_maxHP}");
            Console.WriteLine($"MP: {_mp} / {_maxMP}");
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━");
        }


        public void TakeDamage(int damage)
        {
            hp -= damage;
            if (hp < 0) hp = 0;

            Console.WriteLine($"{name}이(가) {damage} 데미지를 받았습니다!");
            Console.WriteLine($"    남은 HP: {hp} / {maxHP}");
        }

        public void Heal(int amount)
        {
            hp += amount;
            if(hp > maxHP) hp = maxHP;

            Console.WriteLine($"{name}의 HP가 {amount} 회복되었습니다 !");
            Console.WriteLine($"    현재 HP: {hp} / {maxHP}");
        }
    }


    class Class_2
    {
        static void Main(string[] args)
        {
            // 객체 생성
            Character1 player1 = new Character1("김용사", 100, 100, 100, 100, 100);    // 생성자로 조정

            // 필드에 값 할당

            // 메서드 호출
            player1.ShowInfo();

            // 데미지 50
            player1.TakeDamage(50);

            // 힐 30
            player1.Heal(30);

            // 임의 값 입력 후 출력
            Character1 player2 = new Character1();    // 생성자로 조정

            player2.ShowInfo2("나전사", 10, 10, 10, 10, 10);       // 함수로 조정
        }
    }
}
