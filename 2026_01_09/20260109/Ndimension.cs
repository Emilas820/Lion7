using System;

namespace _20260109
{
    internal class Ndimension
    {
        static void Main(string[] args)
        {
            // lecture 2: 다차원 배열

            // 방법 1
            int[,] grid = new int[3, 4];  // 3행 4열 배열 생성

            // 방법 2
            int[,] number = new int[2, 3]
            {
                {1, 2, 3},
                {4, 5, 6}
            };

            // 방법 3
            int[,] scores =
            {
                {1, 2, 3},
                {4, 5, 6},
                {4, 6, 7}
            };

            int[,] arr = new int[3, 4];  // 3행 4열 배열 생성

            int dimensions = arr.Rank;

            int totalelements = arr.Length;

            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);


            // Mission: 좌석 배치
            string[,] seat =
            {
            {"A1", "A2", "A3" },
            {"B1", "B2", "B3" },
            {"C1", "C2", "C3" },
            };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"[{seat[i, j]}]");
                }
                Console.WriteLine();
            }

            // Mission: 좌석 검색

            Console.WriteLine("첫 번째 좌석: " + seat[0, 0]);
            Console.WriteLine("중앙 좌석 " + seat[(seat.GetLength(0)-1)/2, (seat.GetLength(1)-1)/2]);
            Console.WriteLine("마지막 좌석: " + seat[seat.GetLength(0)-1, seat.GetLength(1)-1]);

        }

    }
}
