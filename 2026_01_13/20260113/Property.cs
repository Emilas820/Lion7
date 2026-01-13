using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20260113
{

    class Character2
    {
        private int atk;    // 은닉성, 추상화

        //// Get, Set 함수
        //public void Setatk(int _atk)    // 공격력 값을 변경
        //{
        //    atk = _atk;
        //}

        //public int Getatk() // 공격력 값을 뱉음
        //{
        //    return atk;
        //}
        //private int atk;
        //public int Atk  // private 변수를 안전하게 사용할 수 있게 함 (보안성 + )
        //{
        //    get { return atk; }
        //    set
        //    {
        //        atk = value;
        //    }
        //}

        public int Atk { get; set; }    // 자동 프로퍼티

        // 읽기 전용
        public int MaxHp { get; private set; }
    }

    internal class Property
    {  
        static void Main(string[] args)
        {
            Character2 c = new Character2();

            c.Atk = 1;
            Console.WriteLine("공격력: " + c.Atk);
        }
    }
}
