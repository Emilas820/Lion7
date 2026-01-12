using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20260112
{    
    internal class out_1
    {        
        // out 키워드 - 함수 내에서 초기화 후 값 반환
        static void Attack(int a, int b, out int atk, out int def)
        {
            atk = a;
            def = b;
            atk++;
            def++;
        }

        static void Main(string[] args)
        {
            int Main_atk;
            int Main_def;

            Attack(10, 20, out Main_atk, out Main_def); // a, b는 입력값, out 붙인 애들을 리턴받을 수 있다.
            Console.WriteLine($"공격력: {Main_atk}");
            Console.WriteLine($"방어력: {Main_def}");
        }
    }
}
