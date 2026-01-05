using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_2025_12_31_Vars
{
    internal class Vars_test
    {
        static void Main(string[] args)
        {
            //Lecture 5 - 형식이 같은 변수 여러 개를 한 번에 선언하기
            int x = 10, y = 20, z = 30; // 정수형 변수 x, y, z를 선언하고 각각 초기화.

            Console.WriteLine(x); //x값 출력: 10
            Console.WriteLine(y); //y값 출력: 20
            Console.WriteLine(z); //z값 출력: 30



            // Mission 5_1 - 문자열에 변수값 대입 -> {}
            int age = 5;
            Console.WriteLine("나이: {0}", age);

            string name = "철수";
            Console.WriteLine("이름: {0} 나이: {1}", name, age);

            // 유니티에서 잘 쓰는 방식
            Console.WriteLine("나이:" + age);
            Console.WriteLine($"이름: {name} 나이: {age}");


            // Mission 5_2 각 변수를 세 가지 방식으로 출력하기

            // 좌표 예
            int posX = 0, posY = 50, posZ = 100;

            // RGB 색상 값 예
            int red = 255, green = 128, blue = 50;

            Console.WriteLine("좌표: (" + posX + ", " + posY + ", " + posZ + ") " + "색상: (" + red + ", " + green + ", " + blue + ")");
            Console.WriteLine($"좌표: ({posX}, {posY}, {posZ}) " + $"색상: ({red}, {green}, {blue})");
            Console.WriteLine("좌표: ({0}, {1}, {2}) 색상: ({3}, {4}, {5})", posX, posY, posZ, red, green, blue);


        }
    }
}
