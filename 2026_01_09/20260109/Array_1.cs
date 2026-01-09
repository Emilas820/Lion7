using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _20260109
{
    internal class Array_1
    {
        static void Main(string[] args)
        {
            // Lecture 1 - 배열: 같은 타입의 데이터를 연속된 메모리 공간에 저장하는 자료구조.

            // 배열 선언 방법 1

            int[] score = new int[5]; // 5개의 사물함을 준비

            // 배열 선언 방법 2

            int[] number = new int[] { 10, 20, 30, 40, 50 };

            // 배열 선언 방법 3

            int[] values = { 1, 2, 3, 4, 5 };


            // 특정 번호의 배열에 변수 대입

            score[0] = 1;
            score[1] = 2;
            score[2] = 3;
            score[3] = 4;
            score[4] = 5;

            for(int i = 0; i < score.Length; i++)
            {
                Console.WriteLine(score[i]);
            }

            // * 인벤토리 시스템
            string[] inventory = new string[5];

            // 아이템 추가
            inventory[0] = "회복 포션";
            inventory[1] = "마나 포션";
            inventory[2] = "강철 검";
            inventory[3] = "가죽 갑옷";
            inventory[4] = "마법 반지";

            Console.WriteLine("\n=== 인벤토리 ===");

            for(int i = 0;i < inventory.Length; i++)
            {
                Console.WriteLine($"[{i+1}] {inventory[i]}");
            }

            // 입력을 받아 추가

            for (int i = 0; i < inventory.Length; i++)
            {
                inventory[i] = Console.ReadLine();
            }

            for (int i = 0; i < inventory.Length; i++)
            {
                Console.WriteLine($"[{i + 1}] {inventory[i]}");
            }

        }
    }
}
