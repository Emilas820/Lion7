using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_2025_12_31_literal
{
    internal class Lec_test
    {
        static void Main(string[] args)
        {

            // Lecture 2_1 - 리터럴: 코드에 고정된 값
            int number = 10; //10 is an integer literal
            double pi = 3.14; //3.14 is a double literal
            char letter = 'A'; //'A' is a character literal
            string name = "Alice"; //"Hello" is a string literal

            Console.WriteLine(number);
            Console.WriteLine(pi);
            Console.WriteLine(letter);
            Console.WriteLine(name);
            //줄바꿈 있음


            // Mission 2 - 다음 리터럴을 저장 후 출력

            //플레이 스코어 100
            //파이 3.14
            //등급 A
            //플레이어 이름 홍길동


            int score = 100; //10진수 리터럴
            float piValue = 3.14f; //실수 리터럴
            char grade = 'A'; //문자 리터럴
            string playerName = "홍길동"; //문자열 리터럴
            bool isGameOver = false; //불리언 리터럴

            //결과 출력
            Console.WriteLine(score);
            Console.WriteLine(piValue);
            Console.WriteLine(grade);
            Console.WriteLine(playerName);
            Console.WriteLine(isGameOver);


            


        }
    }
}