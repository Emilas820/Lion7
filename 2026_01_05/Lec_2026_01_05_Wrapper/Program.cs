using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_2026_01_05_Wrapper
{
    internal class WrapperTest
    {
        static void Main(string[] args)
        {

            // Lecture 12: 래퍼 형식은 기본 데이터 형식을 클래스 형태로 감싸 객체 취급을 할 수 있게 함
            int number = 123;
            string numberAsString = number.ToString();  // 정수를 문자열로 변환

            //bool 래퍼 형식의 메서드 활용
            bool flag = true;
            string flagAsString = flag.ToString();      // 논리값을 문자열로 변환

            Console.WriteLine(numberAsString);          // 출력 "123"
            Console.WriteLine(flagAsString);            // 출력 "True"

        }
    }
}
