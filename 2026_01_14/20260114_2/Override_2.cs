using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20260114_2
{
    // 캐릭터(부모) - 워리어(자식) - 메이지(손자)

    public class Character3
    {
        public virtual void Rander()
        {
            Console.WriteLine("캐릭터\n");
        }
    }

    public class Warrior3 : Character3
    {
        public override void Rander()
        {
            Console.WriteLine("워리어\n");
        }
    }

    public class Mage3 : Warrior3
    {
        public override void Rander()
        {
            Console.WriteLine("마법사\n");
        }
    }


    internal class Override_2
    {
        static void Main(string[] args)
        {
            Character3 character = new Character3();
            character.Rander();

            Character3 character2 = new Warrior3(); // 업 캐스팅. 부모 <- 자식 메모리 참조
            character2.Rander();

            Character3 character3 = new Mage3(); // 업 캐스팅. 부모 <- 자식 메모리 참조, 부모의 멤버에만 접근 가능
            character3.Rander();

            Warrior3 warrior = new Warrior3();  // 자식 타입의, 자식 객체 구조의 메모리 생성
            warrior.Rander();

            Warrior3 warrior2 = new Mage3();    // 자식 - 손자 간 업 캐스팅
            warrior2.Rander();

            // Warrior3 warrior2 = new Charcter3(); -> 불가능. 

            Character3 character4 = new Warrior3(); // 다운 캐스팅
            Warrior3 warrior3 = (Warrior3)character4;
            warrior3.Rander();
            character4.Rander();

        }
    }
}
