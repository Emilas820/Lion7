using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20260112
{
    internal class Function_3
    {
        // 반환값이 있는 함수
        static int GetNumber()
        {
            return 42;
        }

        // 문자열 반환
        static string GetString()
        {
            return "문자열";
        }


        // 입력 + 반환
        static string ConnectMessage(string name)
        {
            return name + "님 첩속하셨습니다.";
        }

        static void Main(string[] args)
        {
            int num = GetNumber();
            string str = GetString();

            Console.WriteLine("숫자 반환: " + num);
            Console.WriteLine("문자 반환: " + str);

            string cm = ConnectMessage("천마");
            Console.WriteLine(cm);
        }
    }
}
