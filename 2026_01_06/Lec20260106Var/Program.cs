using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec20260106Var
{
    internal class VarTest
    {
        static void Main(string[] args)
        {
            //Lecture 4: Var을 사용하여 변수 선언
            var name = "Alice";         // 문자열로 추론
            var age = 25;               // 정수로 추론
            var isStudent = true;       // 논리값으로 추론

            Console.WriteLine($"이름: {name}, 나이{age}, 학생 여부: {isStudent}");

        }
    }
}
