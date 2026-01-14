using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20260114_2
{
    internal class Is
    {
        static void Main(string[] args)
        {
            // is - 안전 캐스팅 (객체가 특정 타입인지 확인)

            Character3 character = new Warrior3();
            if (character is Warrior3)
            {
                Warrior3 warrior = (Warrior3)character;
                warrior.Rander();
            }

            // as - 안전 캐스팅 (실패 시 예외를 던지지 않고 null을 반환)

            Warrior3 warrior2 = character as Warrior3;

            if(warrior2 != null)
            {
                warrior2.Rander();
            }
        }
    }
}
