using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20260113
{
    class Character3
    {
        // 정적 멤버 (Static Members)

        // static: 모든 캐릭터가 공유
        public static int totalCount = 0;

        // 일반: 각 캐릭터마다 다름
        public string name;

        public void AddCounter()
        {
            totalCount++;
        }
    }
    internal class Static
    {
        static void Main(string[] args)
        {
            Character3 c1 = new Character3();
            Character3 c2 = new Character3();

            c1.name = "전사";
            c2.name = "마법사";

            Character3.totalCount = 1;  // 생성한 객체가 아닌, 클래스를 호출하여 사용 (해당 클래스의 객체들이 공유하는 값이므로)

            Console.WriteLine(c1.name);
            Console.WriteLine(c2.name);

            c1.AddCounter();
            c2.AddCounter();           

            Console.WriteLine("카운트: " + Character3.totalCount);
        }
        

    }
}
