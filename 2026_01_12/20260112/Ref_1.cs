using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace _20260112
{
    internal class Ref_1
    {
        static int Attack(int a)
        {
            Console.WriteLine("공격력: " + a);
            a++;
            return a; // return받은 a도 값만 같은 상태. Main의 a, Attack의 a는 값만 같아진다.
        }

        static int Attack_2(ref int a)
        {
            Console.WriteLine("공격력2: " + a);
            a++;
            return a; // return받은 a도 값만 같은 상태. Main의 a, Attack의 a는 값만 같아진다.
        }

        static void Main(string[] args)
        {
            // ref 키워드
            // C# 내부적으로 포인터를 쉽게 다룰 수 있게 만들었다.

            int a = 10;
            int b = 20;

            Attack(a); // Attack_a에 10 대입

            a = Attack(a); // Main의 a, Attack의 a는 값만 같아진다. 반환값은 11 (a++)
            Console.WriteLine("a 값: " + a);


            a = Attack_2(ref a); // 주소를 반환함. 실제로 같은 변수가 됨. - Attack에 Main_a의 주소값을 입력.(a = 11, Main_a의 값을 ++)
            b = Attack_2(ref a); // 이름이 달라도 사용 가능. 두 번째 - Attack에 Main_a의 주소값을 입력.(a = 12, Main_a의 값을 ++)
                                 // 변경된 Attack_2_a값을 b에 반환. 결국 Attack_2함수에 두 번 들어갔다 나온 Main_a와 같아진다.

        }
    }
}
