using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_2025_12_31_var_rst
{

    internal class Var_rst_test
    {
        static void Main(string[] args)
        {

            // Lecture 4 - 변수 선언과 초기화를 한 번에 수행
            int score = 100; // 정수형 변수 선언과 동시에 100으로 초기화
            double temperature = 36.5; // 실수형 변수 선언과 초기화
            string city = "Seoul"; // 문자열 변수 선언과 초기화
            

            Console.WriteLine(score); // 출력: 100
            Console.WriteLine(temperature); // 출력: 36.5
            Console.WriteLine(city); // 출력: Seoul

            // Mission 4_1 - 방법 1: 선언 후 할당 (두 줄)

            int health;
            health = 100;

            // Mission 4_2 - 방법 2: 선언과 동시에 할당 (한 줄)

            int maxHealth = 100;
            int damage = 15;

            maxHealth = 90; // maxHealth 값을 90으로 변경

            // Mission 4_3 게임 로직 출력
            Console.WriteLine("Player Health: " + health + "/" + maxHealth);

            //Mission 4_4 데미지를 받았습니다.
            Console.WriteLine("데미지를 받았습니다. ( -" + damage + " )");

        }
    }
}