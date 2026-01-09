using System;
using System.Threading;

namespace _20260109
{
    internal class Array_2
    {
        static void Main(string[] args)
        {
            // Lecture 2 다차원 배열

            // * 인벤토리 시스템
            string[] inventory = new string[5];

            // 아이템 추가
            inventory[0] = "회복 포션";
            inventory[1] = "마나 포션";
            inventory[2] = "강철 검";
            inventory[3] = "가죽 갑옷";
            inventory[4] = "마법 반지";

            Console.WriteLine("=== 인벤토리 ===");
            for (int i = 0; i < inventory.Length; i++)
            {
                Console.WriteLine($"[{i + 1}] {inventory[i]}");
            }


            // 특정 아이템 사용

            Console.WriteLine($"{inventory[0]}을 사용했습니다.");
            inventory[0] = "비어있음";

            Console.WriteLine("\n=== 인벤토리 ===");
            for (int i = 0; i < inventory.Length; i++)
            {
                Console.WriteLine($"[{i + 1}] {inventory[i]}");
            }

            // Mission 1: 캐릭터 스텟

            Console.WriteLine("\n=== 캐릭터 스텟 ===");

            int[] status = { 100, 50, 80, 60, 45 };
            string[] statusName = { "HP", "MP", "ATK", "DFD", "DEX" };

            for (int i = 0; i < inventory.Length; i++)
            {
                Console.WriteLine($"[{statusName[i]}]: {status[i]}");
            }

            // Mission 2: 일일 퀘스트 진행도

            Console.WriteLine("\n=== 일일 퀘스트 진행도 ===");

            string[] questName = { "고블린", "오크", "슬라임", "드래곤", "좀비" };
            int[] quest = { 5, 3, 8, 2, 7 };
            int[] questState = { 5, 5, 5, 5, 5 };

            string result;

            for (int i = 0; i < quest.Length; i++)
            {
                /* 1번 방법
                if (quest[i] <= questState[i])
                {
                    result = "완료 -!";
                }
                else
                {
                    result = "진행중 . . .";
                }
                */

                // 2번 방법

                result = questState[i] <= quest[i] ? "완료 -!" : "진행중 . . .";


                Console.WriteLine($"{questName[i]}: {quest[i]} / {questState[i]} - {result}");
            }



            int[] score = { 85, 92, 78, 95, 88 };

            //배열 길이
            Console.WriteLine("총 점수 개수: " + score.Length);

            // 배열 순회
            Console.WriteLine("개별 점수");
            for (int i = 0; i < score.Length; i++)
            {
                Console.WriteLine($"플레이어 {i + 1}: {score[i]}점");
            }

            // 합계 계산

            int sum = 0;

            for (int i = 0; i < score.Length; i++)
            {
                sum += score[i];
            }

            Console.WriteLine($"총점: {sum}점");
            Console.WriteLine($"평균: {(float)sum / (float)score.Length}점");


            // 최고점, 최저점 구하기

            Console.WriteLine("\n=== 최고 / 최저점 ===");
            int MAX = score[0];
            int MIN = score[0];

            for (int i = 0; i < score.Length; i++)
            {
                MAX = MAX <= score[i] ? score[i] : MAX;
                MIN = MIN >= score[i] ? score[i] : MIN;
            }
            Console.WriteLine($"최고점: {MAX}");
            Console.WriteLine($"최저점: {MIN}");


            // Array 클래스 메서드 활용


            Console.WriteLine("\n=== Array 메서드 ===");

            // 정렬
            int[] sortedScores = (int[])score.Clone(); // 복사본 생성
            Array.Sort(sortedScores);
            Console.WriteLine("\n정렬 후: ");

            for (int i = 0; i < sortedScores.Length; i++)
            {
                Console.WriteLine(sortedScores[i]);
            }

            // 역순 정렬
            Array.Reverse(sortedScores);
            Console.WriteLine("\n역순: ");

            for (int i = 0; i < sortedScores.Length; i++)
            {
                Console.WriteLine(sortedScores[i]);
            }

            Console.WriteLine("\n=== foreach ===");

            // 반복문 foreach - 각각
            foreach (int scores in sortedScores) // scores 을 sortedScores 전부 넣으쇼
            {
                Console.WriteLine(scores);
            }

            Console.WriteLine("\n=== 좌석 검색 ===");
            // 검색
            int searchScore = 92;
            int index = Array.IndexOf(score, searchScore);
            Console.WriteLine($"{searchScore}점의 위치: 인덱스 {index}");
            Console.WriteLine("찾은 값:" + score[index]);

        }
    }
}
